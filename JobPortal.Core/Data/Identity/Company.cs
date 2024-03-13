using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Identity
{
	public class Company
	{

		[Key]
		public int Id { get; set; }
		[ForeignKey(nameof(User))]
		[Required]
		public string UserId { get; set; } = null!;
		public virtual AppUser User { get; set; } = null!;

		[Required]
		public string CompanyName { get; set; } = null!;
		[Required]
		public string Address { get; set; } = null!;
		[Required]
		public string Location { get; set; } = null!;
	}
}