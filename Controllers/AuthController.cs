using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace workwise.assistive.backend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private UserManager<IdentityUser> _userManager;

        public AuthController(UserManager<IdentityUser> userManager) => _userManager = userManager;

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login(string returnUrl = "/")
        {
            return new ChallengeResult("OpenIdConnect", new AuthenticationProperties()
            {
                RedirectUri = returnUrl
            });
        }

        [HttpGet]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return new SignOutResult("OpenIdConnect", new AuthenticationProperties
            {
                RedirectUri = Url.Action("Index", "Home")
            });
        }

        [HttpGet]
        public ActionResult<object> GetUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var claims = ((List<ClaimsIdentity>)this.User.Identities).SelectMany(i => i.Claims)
                    .Select(c => new { type = c.Type, value = c.Value })
                    .Where(claim => claim.type == "name" || claim.type == "preferred_username" || claim.type.EndsWith("emailaddress") || claim.type.EndsWith("role"))
                    .ToArray();

                return new { isAuthenticated = true, claims };
            }

            return new { isAuthenticated = false };
        }

        //[HttpGet]
        //public async Task<ActionResult> RefreshRoles()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    var roles = await _userManager.GetRolesAsync(user);
        //    var roleClaims = roles.Select(role => new Claim(ClaimTypes.Role, role)).ToList();
        //    var roleClaimIdentity = new ClaimsIdentity(roleClaims, "custom-rbac", "", ClaimTypes.Role);
        //    //TODO remove all claims in custom-rbac and add all from 
        //    var test =  User.Identities.Where(i => i.AuthenticationType == "custom-rbac").SelectMany(i => i.Claims).ToList();
        //    foreach (var claim in roleClaims)
        //    {
        //        test.Remove(claim);
        //    }
        //    return this.Ok();
        //}
    }
}
