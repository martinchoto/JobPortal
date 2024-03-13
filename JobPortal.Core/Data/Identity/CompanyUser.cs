using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Core.Data.Identity
{
	public class CompanyUser : AppUser
	{
		[Required]
		public string CompanyName { get; set; } = null!;
		[Required]
		public string Address { get; set; } = null!;
		[Required]
		public string LogoUrl { get; set; } = null!;
		[Required]
		public string Description { get; set; } = null!;
	}
}
