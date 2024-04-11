using JobPortal.Core.Data.Enums;
using JobPortal.Core.Data.Identity;
using JobPortal.Services.Admin.Models;
using JobPortal.Services.Event.Models;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.ViewModels.Admin
{
	public class AllUsersQueryModel
	{
		public string Role { get; set; } = null!;
		[Display(Name = "Search by text")]
		public string SearchTerm { get; set; } = null!;
		[Display(Name = "Sorting")]
		public AdminSorting AdminSorting { get; set; }
		[Display(Name = "Users per page")]
		public int UsersPerPage { get; set; }
		public int CurrentPage { get; set; } = 1;
		public int TotalUsersCount { get; set; }
		public List<string> Roles { get; set; } = null!;

		public List<UserServiceModel> Users { get; set; } = new List<UserServiceModel>();
	}
}
