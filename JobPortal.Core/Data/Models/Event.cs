using JobPortal.Core.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Core.Data.Models
{
	public class Event
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(DataConstants.EVENT_NAME)]
		public string Name { get; set; } = null!;
		[Required]
		public string Description { get; set; } = null!;
		public DateTime Date { get; set; }
		[Required]
		public string ImageUrl { get; set; } = null!;
		[ForeignKey(nameof(Company))]
		public int CompanyId { get; set; }
		public virtual Company Company { get; set; } = null!;
		public virtual List<EventParticipants> EventParticipants { get; set; } = new List<EventParticipants>();

	}
}
