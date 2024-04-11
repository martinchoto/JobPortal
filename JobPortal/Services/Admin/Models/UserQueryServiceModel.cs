using JobPortal.Core.Data.Identity;

namespace JobPortal.Services.Admin.Models
{
	public class UserQueryServiceModel
	{
		public int TotalUsersCount { get; set; }
		public List<UserServiceModel> Users { get; set; } = new List<UserServiceModel>();
	}
}
