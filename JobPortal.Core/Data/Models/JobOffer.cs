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
        public string Position { get; set; } = null!;
        [Required]
        public string Status { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public decimal Salary { get; set; }
        public int VacationDays { get; set; }
        [Required]
        public string Bonus { get; set; } = null!;
        public DateTime PostedDate { get; set; }
        [ForeignKey(nameof(User))]
        [Required]
        public string UserId { get; set; } = null!;
        public virtual AppUser User { get; set; } = null!;
        [ForeignKey(nameof(Type))]
        public int TypeId { get; set; }
        public virtual Type Type { get; set; } = null!;
    }
}
