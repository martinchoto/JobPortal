using JobPortal.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.ViewModels.Application
{
	public class AddJobApplicationViewModel
	{
		[Required]
		[Display(Name = "Application Name")]
        [StringLength(DataConstants.APP_NAME)]
        public string ApplicationName { get; set; } = null!;
		[Required]
		[Display(Name = "Full Name")]
        [StringLength(DataConstants.APP_FULLNAME)]
        public string FullName { get; set; } = null!;
		[Required]
		[EmailAddress]
        [StringLength(DataConstants.APP_EMAIL)]
        public string Email { get; set; } = null!;
		[Required]
		public string Description { get; set; } = null!;
		[Required]
		public string Reasons { get; set; } = null!;
	}
}
