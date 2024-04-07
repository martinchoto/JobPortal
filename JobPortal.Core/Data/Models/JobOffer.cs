using JobPortal.Core.Constants;
using JobPortal.Core.Data.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Models
{
	public class JobOffer
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(DataConstants.JOBOFFER_POSITION)]
		public string Position { get; set; } = null!;
		[Required]
        [StringLength(DataConstants.JOBOFFER_STATUS)]
        public string Status { get; set; } = null!;
		[Required]
		public string Description { get; set; } = null!;
		public decimal Salary { get; set; }
		public int VacationDays { get; set; }
		[Required]
        [StringLength(DataConstants.JOBOFFER_BONUS)]
        public string Bonus { get; set; } = null!;
		public DateTime PostedDate { get; set; }
		[ForeignKey(nameof(Company))]
		public int CompanyId { get; set; }
		public virtual Company Company { get; set; } = null!;
		[ForeignKey(nameof(Type))]
		public int TypeId { get; set; }
		public virtual Type Type { get; set; } = null!;
		public virtual List<JobOfferApplication> JobOfferApplications { get; set; } = new List<JobOfferApplication>();
	}
}
