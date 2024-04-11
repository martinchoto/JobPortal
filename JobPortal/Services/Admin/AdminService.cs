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
			return await _roleManager.Roles.Select(x => x.Name).ToListAsync();
		}
		public async Task<string> GetRole(string id)
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
			var usersQuery = _userManager.Users.AsQueryable();

			if (!string.IsNullOrEmpty(role))
			{
				
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

			var users = await usersQuery
				.Skip(skipAmount)
				.Take(usersPerPage)
				.Select(x => new UserServiceModel
				{
					Id = x.Id,
					UserName = x.UserName,
					Email = x.Email,
					CreatedOn = x.CreatedOn,
				})
				.ToListAsync();

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
	}
}
