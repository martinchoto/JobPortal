using JobPortal.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.Core.Data.Identity
{
	public class AppUser : IdentityUser
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public DateTime CreatedOn {  get; set; }
		public virtual List<JobApplication> Applications { get; set; } = new List<JobApplication>();
		public virtual List<EventParticipants> EventParticipants { get; set; } = new List<EventParticipants>();
	}
}
