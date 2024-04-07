using JobPortal.Core.Data.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JobPortal.Core.Constants;

namespace JobPortal.ViewModels.Company
{
    public class AddJobOfferViewModel
    {
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
        [Required]
        public string UserId { get; set; } = null!;
        [Required(ErrorMessage = "Please select a type!")]
        public int TypeId { get; set; }
        public List<TypesViewModel> Types { get; set; } = new List<TypesViewModel>();
    }
}
