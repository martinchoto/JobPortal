﻿using JobPortal.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.ViewModels.Event
{
	public class AddEventViewModel
	{
		[Required]
		[StringLength(DataConstants.EVENT_NAME)]
		public string Name { get; set; } = null!;
		[Required]
		public string ImageUrl { get; set; } = null!;
		[Required]
		public string Description { get; set; } = null!;
		public DateTime Date { get; set; }

		public int CompanyId { get; set; }
	}
}
