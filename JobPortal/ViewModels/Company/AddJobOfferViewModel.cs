using JobPortal.Core.Data.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.ViewModels.Company
{
    public class AddJobOfferViewModel
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
        [Required]
        public string UserId { get; set; } = null!;
        public int TypeId { get; set; }
        public List<TypesViewModel> Types { get; set; } = new List<TypesViewModel>();
    }
}
