using JobPortal.Core.Data.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Core.Data.Models
{
	public class Company
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[ForeignKey(nameof(User))]
		public string UserId { get; set; } = null!;
		public virtual AppUser User { get; set; } = null!;
	}
}
