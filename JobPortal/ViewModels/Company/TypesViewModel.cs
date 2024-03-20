using System.ComponentModel.DataAnnotations;

namespace JobPortal.ViewModels.Company
{
    public class TypesViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; } = null!;
    }
}