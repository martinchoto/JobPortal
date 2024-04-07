using JobPortal.Core.Constants;
using JobPortal.Core.Data.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Models
{
	public class JobApplication
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(DataConstants.APP_NAME)]
		public string Name { get; set; } = null!;
		public DateTime CreatedOn { get; set; }
		[Required]
        [StringLength(DataConstants.APP_FULLNAME)]
        public string FullName { get; set; } = null!;
		[Required]
        [StringLength(DataConstants.APP_EMAIL)]
        public string Email { get; set; } = null!;
		[Required]
		public string Description { get; set; } = null!;
		[Required]
		public string Reason { get; set; } = null!;
		[Required]
		[ForeignKey(nameof(User))]
		public string UserId { get; set; } = null!;
		public virtual AppUser User { get; set; } = null!;
		public virtual List<JobOfferApplication> JobOfferApplications { get; set; } = new List<JobOfferApplication>();
	}
}
