

namespace JobPortal.Services.Admin
{
	using JobPortal.Core.Data.Enums;
	using JobPortal.Core.Data.Identity;
	using JobPortal.Core.Data.Models;
	using JobPortal.Services.Admin.Models;
	public interface IAdminService
	{
		Task<UserQueryServiceModel> Users(string role = null,
			string searchTerm = null,
			AdminSorting adminSorting = AdminSorting.Newest,
			int currentPage = 1,
			int usersPerPage = 1);
		Task<List<string>> AllRoles();
		Task<bool> HasRole(AppUser user, string role);
		Task<AppUser> FindUserById(string id);
		Task<Company> FindCompanyByUserId(string id);
		Task DeleteCompany(Company company);
		Task<bool> DeleteUser(AppUser user);
	}
}
