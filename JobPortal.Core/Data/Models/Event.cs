using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Core.Data.Models
{
	public class Event
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = null!;
		[Required]
		public string Description { get; set; } = null!;
		public DateTime Date { get; set; }
		[ForeignKey(nameof(Company))]
		public int CompanyId { get; set; }
		public virtual Company Company { get; set; } = null!;
		public virtual List<EventParticipants> EventParticipants { get; set; } = new List<EventParticipants>();

	}
}
