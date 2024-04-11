using JobPortal.Core.Data.Enums;
using JobPortal.Services.Admin.Models;

namespace JobPortal.Services.Admin
{
	public interface IAdminService
	{
		Task<UserQueryServiceModel> Users(string role = null,
			string searchTerm = null,
			AdminSorting adminSorting = AdminSorting.Newest,
			int currentPage = 1,
			int usersPerPage = 1);
		Task<List<string>> AllRoles();
	}
}
