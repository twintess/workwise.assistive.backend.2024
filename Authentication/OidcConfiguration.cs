using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Security.Claims;
using workwise.assistive.backend.Model;

namespace workwise.assistive.backend.Authentication
{
    public static class OidcConfiguration
    {
        public static void SetOptions(OpenIdConnectOptions options)
        {
            options.Authority = Program.StaticConfig["AzureAd:Instance"];
            options.ClientId = Program.StaticConfig["AzureAd:ClientId"];
            options.ClientSecret = Program.StaticConfig["AzureAd:ClientSecret"];
            options.ResponseType = OpenIdConnectResponseType.CodeIdToken;
            options.ResponseMode = OpenIdConnectResponseMode.FormPost;
            options.Scope.Clear();
            options.Scope.Add("email");
            options.Scope.Add("offline_access");
            options.Scope.Add("openid");
            options.Scope.Add("profile");
            options.CallbackPath = new PathString(Program.StaticConfig["AzureAd:CallbackPath"]);
            options.SaveTokens = true;

            options.Events = new OpenIdConnectEvents
            {
                OnRedirectToIdentityProviderForSignOut = (context) =>
                {
                    var logoutUri = $"https://{Program.StaticConfig["AzureAd:Instance"]}/v2/logout?client_id={Program.StaticConfig["AzureAd:ClientId"]}";

                    var postLogoutUri = context.Properties.RedirectUri;
                    if (!string.IsNullOrEmpty(postLogoutUri))
                    {
                        if (postLogoutUri.StartsWith("/"))
                        {
                            // transform to absolute
                            var request = context.Request;
                            postLogoutUri = request.Scheme + "://" + request.Host + request.PathBase + postLogoutUri;
                        }
                        logoutUri += $"&returnTo={Uri.EscapeDataString(postLogoutUri)}";
                    }
                    context.Response.Redirect(logoutUri);
                    context.HandleResponse();

                    return Task.CompletedTask;
                },
                //OnRedirectToIdentityProvider = context =>
                //{
                //    return Task.CompletedTask;
                //},
                OnTokenValidated = async context =>
                {
                    var userManager = context.HttpContext.RequestServices.GetRequiredService<UserManager<IdentityUser>>();

                    var claims = ((ClaimsIdentity)context.Principal.Identity).Claims;
                    var oidClaim = claims.First(claim => claim.Type.Contains("objectidentifier"));
                    var usernameClaim = claims.First(claim => claim.Type.Contains("preferred_username"));
                    var emailClaim = claims.First(claim => claim.Type.Contains("emailaddress"));
                    var nameClaim = claims.First(claim => claim.Type == "name");    //name and surname

                    var user = await userManager.FindByIdAsync(oidClaim.Value);

                    if (user == null)
                    {
                        user = new IdentityUser
                        {
                            Id = oidClaim.Value,
                            UserName = usernameClaim.Value,
                            Email = emailClaim.Value,
                        };

                        var result = await userManager.CreateAsync(user);

                        if (!result.Succeeded)
                        {
                            context.Fail("OIDC succeded but failed to create user");
                        }
                        else
                        {

                            var dbContext = context.HttpContext.RequestServices.GetRequiredService<ApplicationDbContext>();
                            dbContext.PortalUsers.Add(new PortalUser
                            {
                                User = user,
                                Name = nameClaim.Value
                            });
                            dbContext.SaveChanges();
                        }
                    }
                    
                    //add claim roles to identity
                    var roles = await userManager.GetRolesAsync(user);
                    var roleClaims = roles.Select(role => new Claim(ClaimTypes.Role, role)).ToList();
                    var roleClaimIdentity = new ClaimsIdentity(roleClaims, "custom-rbac", "", ClaimTypes.Role);
                    context.Principal.AddIdentity(roleClaimIdentity);
                }
            };
        }
    }
}
