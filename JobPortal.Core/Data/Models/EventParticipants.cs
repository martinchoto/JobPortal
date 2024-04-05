using JobPortal.Core.Data.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Core.Data.Models
{
	public class EventParticipants
	{
		public int EventId { get; set; }
		public virtual Event Event { get; set; } = null!;
		[Required]
		public string ParticipantId { get; set; } = null!;
		public virtual AppUser Participant { get; set; } = null!;
	}
}
