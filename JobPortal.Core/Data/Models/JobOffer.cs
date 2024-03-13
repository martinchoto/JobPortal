using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Models
{
	public class JobOffer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public string Requirements { get; set; } = null!;
        public decimal Salary { get; set; }
        [Required]
        public string Location { get; set; } = null!;
    }
}
