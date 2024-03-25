using System.ComponentModel.DataAnnotations;

namespace JobPortal.ViewModels.Application
{
	public class AddJobApplicationViewModel
	{
		[Required]
		[Display(Name = "Application Name")]
		public string ApplicationName { get; set; } = null!;
		[Required]
		[Display(Name = "Full Name")]
		public string FullName { get; set; } = null!;
		[Required]
		[EmailAddress]
		public string Email { get; set; } = null!;
		[Required]
		public string Description { get; set; } = null!;
		[Required]
		public string Reasons { get; set; } = null!;
	}
}
