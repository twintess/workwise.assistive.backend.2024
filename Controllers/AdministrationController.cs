using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using workwise.assistive.backend.Model;

namespace workwise.assistive.backend.Controllers
{
    [Authorize(Roles = "portal-admin")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdministrationController : ControllerBase
    {
        private UserManager<IdentityUser> _userManager;
        private ApplicationDbContext _dbContext;

        public AdministrationController(UserManager<IdentityUser> userManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<DbSet<PortalUser>> GetAllUsers()
        {
            return _dbContext.PortalUsers;
        }

        [HttpPost]
        public async Task<IList<string>> GetRolesForUser(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if(user is not null)
            {
                var roles = await _userManager.GetRolesAsync(user);
                return roles;
            }
            else
            {
                return [];
            }
        }

        [HttpPost]
        public async Task<IList<IdentityUser>> GetUsersWithRole(string roleName)
        {
            return await _userManager.GetUsersInRoleAsync(roleName);
        }
    }
}
