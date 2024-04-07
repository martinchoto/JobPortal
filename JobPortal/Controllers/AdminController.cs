using JobPortal.Core.Data;
using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
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

        public AdminController(UserManager<AppUser> userManager, 
            RoleManager<IdentityRole> roleManager,
            JobPortalDbContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Users()
        {
            List<AppUser> users = await _userManager.Users.OrderByDescending(x => x.CreatedOn).ToListAsync();
            return View(users);
        }
        public async Task<IActionResult> DeleteUser(string id)
        {
            AppUser user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
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
