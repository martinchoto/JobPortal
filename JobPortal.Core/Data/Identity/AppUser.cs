using JobPortal.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.Core.Data.Identity
{
	public class AppUser : IdentityUser
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public virtual List<Application> Applications { get; set; } = new List<Application>();

		// for companies variant
		public string? CompanyName { get; set; }
		public string? LogoUrl { get; set; }
		public string? Address { get; set; } 
		public string? Location { get; set; }
	}
}
