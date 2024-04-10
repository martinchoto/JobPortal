using JobPortal.Services.Job.Models;

namespace JobPortal.Services.Event.Models
{
	public class EventQueryServiceModel
	{
		public int TotalEventsCount { get; set; }
		public List<EventServiceModel> Events { get; set; } = new List<EventServiceModel>();
	}
}
