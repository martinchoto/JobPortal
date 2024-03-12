using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
    }
}
