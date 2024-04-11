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
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
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
            AppUser user = await _adminService.FindUserById(id);
            if (await _adminService.HasRole(user, "Admin"))
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
            Company associatedCompany = await _adminService.FindCompanyByUserId(user.Id);
            if (associatedCompany != null)
            {
                await _adminService.DeleteCompany(associatedCompany);
            }
            await _adminService.DeleteUser(user);
            return RedirectToAction(nameof(Users), "Admin");
        }
    }
}
