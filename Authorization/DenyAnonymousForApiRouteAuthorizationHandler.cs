using Microsoft.AspNetCore.Authorization;

namespace workwise.assistive.backend.Authorization
{
    public class DenyAnonymousForApiRouteAuthorizationHandler : AuthorizationHandler<DenyAnonymousForApiRouteAuthorizationHandler>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, DenyAnonymousForApiRouteAuthorizationHandler requirement)
        {
            var user = context.User;
            var userIsAnonymous = user?.Identity == null || !user.Identities.Any(i => i.IsAuthenticated);

            var defaultContext = context.Resource as DefaultHttpContext;

            var isRouteQualified = false;

            if (defaultContext?.GetEndpoint() is RouteEndpoint routeEndpoint)
            {
                var pattern = routeEndpoint?.RoutePattern;
                isRouteQualified = pattern?.RawText == "{*path:nonfile}" || pattern?.Defaults.Count == 0;
            }
            else
            {
                isRouteQualified = true;
            }

            if (userIsAnonymous && isRouteQualified)
            {
                context.Succeed(requirement);
            }
            else if(!userIsAnonymous && !isRouteQualified)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
