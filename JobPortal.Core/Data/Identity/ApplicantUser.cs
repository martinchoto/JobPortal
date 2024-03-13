using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Core.Data.Identity
{
	public class ApplicantUser : AppUser
	{
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public DateTime Birthday { get; set; }
	}
}
