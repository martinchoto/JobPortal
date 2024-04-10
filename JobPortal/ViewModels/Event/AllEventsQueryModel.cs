using JobPortal.Core.Data.Enums;
using JobPortal.Core.Enums;
using JobPortal.Services.Event.Models;
using JobPortal.Services.Job.Models;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.ViewModels.Event
{
	public class AllEventsQueryModel
	{
		[Display(Name = "Search by text")]
		public string SearchTerm { get; set; } = null!;
		[Display(Name = "Sorting")]
		public EventSorting EventSorting { get; set; }
		[Display(Name = "Events per page")]
		public int EventsPerPage { get; set; }
		public int CurrentPage { get; set; } = 1;
		public int TotalEventsCount { get; set; }

		public List<EventServiceModel> Events { get; set; } = new List<EventServiceModel>();
	}
}
