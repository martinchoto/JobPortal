using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.Core.Data.Identity
{
	public class AppUser : IdentityUser
	{
		[Required]
		public string FirstName { get; set; } = null!;
		[Required]
		public string LastName { get; set; } = null!;

		// for companies variant
		public string? CompanyName { get; set; }
		public string? LogoUrl { get; set; }
		public string? Address { get; set; } 
		public string? Location { get; set; }
	}
}
