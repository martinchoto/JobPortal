using System.ComponentModel.DataAnnotations;

namespace JobPortal.Core.Data.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null;
        [Required]
        public string LogoUrl { get; set; } = null!;
        [Required]

        public string Email { get; set; } = null!;
        [Required]
        public string Address { get; set; } = null!;
    }
}