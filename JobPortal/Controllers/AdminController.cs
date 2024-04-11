using JobPortal.Core.Data;
using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using JobPortal.Services.Admin;
using JobPortal.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JobPortalDbContext _dbContext;
        private readonly IAdminService _adminService;

        public AdminController(UserManager<AppUser> userManager, 
            RoleManager<IdentityRole> roleManager,
            JobPortalDbContext dbContext, IAdminService adminService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
            _adminService = adminService;
        }

        public async Task<IActionResult> Users([FromQuery] AllUsersQueryModel query)
        {
			if (query.UsersPerPage < 5)
			{
				return RedirectToAction("Users", "Admin", new { usersPerPage = 5 });
			}
			var queryResult = await _adminService.Users(
				query.Role,
				query.SearchTerm,
				query.AdminSorting,
				query.CurrentPage,
				query.UsersPerPage);

			query.TotalUsersCount = queryResult.TotalUsersCount;
			query.Users = queryResult.Users;
			query.Roles = await _adminService.AllRoles();

			return View(query);
		}
        public async Task<IActionResult> DeleteUser(string id)
        {
            AppUser user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                return Unauthorized();
            }
            if (user == null)
            {
                return BadRequest();
            }
            if (user.Applications.Any() || user.EventParticipants.Any())
            {
                user.Applications.Clear();
                user.EventParticipants.Clear();
            }
            Company associatedCompany = await _dbContext.Companies.FirstOrDefaultAsync(c => c.UserId == id);
            if (associatedCompany != null)
            {
                _dbContext.Companies.Remove(associatedCompany);
                await _dbContext.SaveChangesAsync(); 
            }
            var result = await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Users), "Admin");
        }
    }
}
