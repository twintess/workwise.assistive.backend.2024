using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace workwise.assistive.backend.Authentication
{
    public static class CookieConfiguration
    {
        public static Action<AuthenticationOptions> AuthenticationOptions
        {
            get
            {
                return options =>
                {
                    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                };
            }
        }

        public static Action<CookieAuthenticationOptions> CookieOptions
        {
            get
            {
                return options =>
                {
                    var isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";

                    if (isDevelopment)
                    {
                        options.Cookie.SameSite = SameSiteMode.None;
                    }
                    else
                    {
                        options.Cookie.SameSite = SameSiteMode.Strict;
                    }
                    //options.LoginPath = "/api/auth/login";
                    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    options.Cookie.HttpOnly = true;

                    options.Events = new CookieAuthenticationEvents
                    {
                        OnRedirectToAccessDenied = context =>
                        {
                            if (context.HttpContext.User.Identities.All(i => i.IsAuthenticated == true))
                            {
                                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                            }
                            else
                            {
                                context.Response.Redirect(context.Options.LoginPath, true);
                            }
                            return Task.CompletedTask;
                        },
                        OnRedirectToLogin = context =>
                        {
                            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                            return Task.CompletedTask;
                        },
                    };
                };
            }
        }
    }
}
