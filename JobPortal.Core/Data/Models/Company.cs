using JobPortal.Core.Constants;
using JobPortal.Core.Data.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Models
{
	public class Company
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[ForeignKey(nameof(User))]
		public string UserId { get; set; } = null!;
		public virtual AppUser User { get; set; } = null!;
		[Required]
        [StringLength(DataConstants.COMPANY_LEN)]
        public string CompanyName { get; set; } = null!;
		[Required]
		public string LogoUrl { get; set; } = null!;
		[Required]
        [StringLength(DataConstants.ADDRESS_LEN)]
        public string Address { get; set; } = null!;
		[Required]
        [StringLength(DataConstants.LOCATION_LEN)]
        public string Location { get; set; } = null!;
		public virtual List<Event> Events { get; set; } = new List<Event>();
	}
}
