using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using workwise.assistive.backend;
using workwise.assistive.backend.Authentication;
using workwise.assistive.backend.Authorization;

internal class Program
{
    public static IConfiguration StaticConfig { get; private set; }
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        StaticConfig = builder.Configuration;

        // Add services to the container.
        builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("workwise")));

        builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddCors(options =>
        {
            if (builder.Environment.IsDevelopment())
            {
                options.AddDefaultPolicy(policy =>
                    {
                        policy.WithOrigins("http://localhost:5173")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
            }
        });

        builder.Services.AddAuthentication(CookieConfiguration.AuthenticationOptions)
        .AddCookie(CookieConfiguration.CookieOptions)
        .AddOpenIdConnect("OpenIdConnect", OidcConfiguration.SetOptions);

        builder.Services.AddAuthorization(options =>
        {
            if (builder.Environment.IsDevelopment())
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .AddRequirements(new DenyAnonymousForApiRouteAuthorizationHandler())
                .Build();
            }
            else
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .AddRequirements(new DenyAnonymousForApiRouteAuthorizationHandler())
                .AddRequirements(new SpaRouteAuthorizationHandler())
                .Build();
            }
        });

        builder.Services.AddSpaStaticFiles(options =>
        {
            options.RootPath = "workwise.assistive.frontend/dist";
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseCors();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseSpaStaticFiles();

        app.MapControllers();

        app.UseSpa(spa =>
        {
            spa.Options.SourcePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "workwise.assistive.frontend", "dist");

            if (app.Environment.IsDevelopment())
            {
                //spa.UseProxyToSpaDevelopmentServer("http://localhost:5173");
            }
        });

        app.MapFallbackToFile("index.html");

        app.Run();
    }
}