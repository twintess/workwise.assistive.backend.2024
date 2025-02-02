using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace workwise.assistive.backend.Authorization
{
    public class SpaRouteAuthorizationHandler : AuthorizationHandler<SpaRouteAuthorizationHandler>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, SpaRouteAuthorizationHandler requirement)
        {
            var defaultContext = context.Resource as DefaultHttpContext;

            var regex = new Regex("^\\/(login)?$");
            var requestPath = defaultContext?.Request.Path.Value;

            if (!string.IsNullOrEmpty(requestPath))
            {
                if (regex.IsMatch(requestPath))
                {
                    context.Succeed(requirement);
                }
                else
                {
                    var user = context.User;
                    var isAUthenticated = (user.Identity?.IsAuthenticated ?? false) && user.Identities.All(i => i.IsAuthenticated);

                    if (isAUthenticated)
                    {
                        context.Succeed(requirement);
                    }
                }
            }

            return Task.CompletedTask;
        }
    }
}
