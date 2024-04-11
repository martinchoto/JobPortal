using System.Security.Cryptography.Pkcs;

namespace JobPortal.Services.Admin.Models
{
	public class UserServiceModel
	{
		public string Id { get; set; } = null!;
		public string UserName { get; set; } = null!;
		public string Email { get; set; } = null!;
		public DateTime CreatedOn { get; set; }
		public string? Role { get; set; }
	}
}
