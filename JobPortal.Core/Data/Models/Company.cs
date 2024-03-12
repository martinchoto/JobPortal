using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Models
{
    public class Company
    {
        public Company()
        {
            JobOffers = new HashSet<JobOffer>();
        } 
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public string LogoUrl { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Creator))]
        public string CreatorId { get; set; } = null!;
        public IdentityUser Creator { get; set; } = null!;
        public string Email { get; set; } = null!;
        [Required]
        public string Address { get; set; } = null!;
        public virtual ICollection<JobOffer> JobOffers { get; set; }
    }
}