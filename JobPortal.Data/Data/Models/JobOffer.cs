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
        [StringLength(50)]
        public string Position { get; set; } = null!;
        [Required]
		[StringLength(50)]
		public string Status { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public decimal Salary { get; set; }
        public int VacationDays { get; set; }
        [Required]
        [StringLength(50)]
        public string Bonus { get; set; } = null!;
        public DateTime PostedDate { get; set; }
        [ForeignKey(nameof(Company))]
        [Required]
        public string CompanyId { get; set; } = null!;
        public virtual AppUser Company { get; set; } = null!;
        [ForeignKey(nameof(Type))]
        public int TypeId { get; set; }
        public virtual Type Type { get; set; } = null!;
    }
}
