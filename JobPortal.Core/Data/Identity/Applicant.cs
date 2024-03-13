using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Identity
{
	public class Applicant
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey(nameof(User))]
		[Required]
		public string UserId { get; set; } = null!;
		public virtual AppUser User { get; set; } = null!;
		[Required]
		public string FirstName { get; set; } = null!;
		[Required]
		public string LastName { get; set; } = null!;
		public DateTime Birthday { get; set; }
	}
}