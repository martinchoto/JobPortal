using Castle.Core.Internal;
using JobPortal.Core.Constants;
using JobPortal.Core.Data;
using JobPortal.Core.Data.Enums;
using JobPortal.Core.Data.Identity;

using JobPortal.Core.Enums;
using JobPortal.Services.Admin.Models;
using JobPortal.Services.Job.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace JobPortal.Services.Admin
{
	using JobPortal.Core.Data.Models;
	public class AdminService : IAdminService
	{
		private readonly JobPortalDbContext _context;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly UserManager<AppUser> _userManager;
		public AdminService(JobPortalDbContext context,
			RoleManager<IdentityRole> roleManager,
			UserManager<AppUser> userManager)
		{
			_context = context;
			_roleManager = roleManager;
			_userManager = userManager;
		}

		public async Task<List<string>> AllRoles()
		{
			return await _roleManager.Roles.OrderBy(x => x.Name).Select(x => x.Name).ToListAsync();
		}
		private async Task<string> GetRole(string id)
		{
			var user = await _userManager.FindByIdAsync(id);

			if (user == null)
			{
				return null;
			}
			var userRoles = await _userManager.GetRolesAsync(user);

			if (userRoles.Count == 0)
			{
				return null;
			}

			return userRoles[0];
		}
		public async Task<UserQueryServiceModel> Users(string role = null,
			string searchTerm = null,
			AdminSorting sorting = AdminSorting.Newest,
			int currentPage = 1, int usersPerPage = 1)
		{
			var usersQuery = _userManager.Users.AsEnumerable();

			//Тайна е как проработи тва
			if (!string.IsNullOrEmpty(role))
			{
				List<AppUser> usersWithRoles = new List<AppUser>();
				foreach (var user in usersQuery)
				{
					if (await _userManager.IsInRoleAsync(user, role))
					{
						usersWithRoles.Add(user);
					}
					usersQuery = usersWithRoles.AsEnumerable();
				}
			}

			if (!string.IsNullOrEmpty(searchTerm))
			{
				usersQuery = usersQuery.Where(x => x.UserName.ToLower().Contains(searchTerm.ToLower()) ||
					x.Email.ToLower().Contains(searchTerm.ToLower()) ||
					x.Id.ToLower() == searchTerm.ToLower());
			}

			usersQuery = sorting switch
			{
				AdminSorting.Newest => usersQuery
					.OrderByDescending(u => u.CreatedOn),
				AdminSorting.Oldest => usersQuery
					.OrderBy(u => u.CreatedOn),
				_ => usersQuery.OrderBy(x => x.UserName)
			};

			var skipAmount = (currentPage - 1) * usersPerPage;

			var users = usersQuery
				.Skip(skipAmount)
				.Take(usersPerPage)
				.Select(x => new UserServiceModel
				{
					Id = x.Id,
					UserName = x.UserName,
					Email = x.Email,
					CreatedOn = x.CreatedOn,
				}).ToList();


			foreach (var user in users)
			{
				user.Role = await GetRole(user.Id);
			}

			var totalUsers = usersQuery.Count();

			return new UserQueryServiceModel()
			{
				Users = users,
				TotalUsersCount = totalUsers
			};
		}

		public async Task<AppUser> FindUserById(string id)
		{
			return await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<Company> FindCompanyByUserId(string id)
		{
			return await _context.Companies.FirstOrDefaultAsync(c => c.UserId == id);
		}

		public async Task DeleteCompany(Company company)
		{
			_context.Companies.Remove(company);
			await _context.SaveChangesAsync();
		}

		public async Task<bool> DeleteUser(AppUser user)
		{
			var result = await _userManager.DeleteAsync(user);
			if (result.Succeeded)
				return true;
			return false;
		}

		public async Task<bool> HasRole(AppUser user, string role)
		{
			return await _userManager.IsInRoleAsync(user, role);
		}
	}
}
