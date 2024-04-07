namespace JobPortal.Services.Event
{
	using JobPortal.Core.Data.Models;
	using JobPortal.ViewModels.Event;
	using JobPortal.ViewModels.Job;
	public interface IEventService
	{
		Task<Company> FindCompanyByUserIdAsync(string userId);
		Task AddEventAsync(int companyId, AddEventViewModel viewModel);
		Task<List<AllEventsViewModel>> GetAllEventsAsync();
		Task<EventDetailsViewModel> GetEventDetailsAsync(Event e);
		Task<Event> GetEventAsync(int id);
		Task JoinEvent(EventParticipants eventParticipants);
		Task<bool> AlreadyJoinedEvent(string userId, int eventId);
		Task<EventParticipants> GetEventParticipantsByUserIdAsync(string userId, int eventId);
		Task LeaveEvent(EventParticipants ep);
		Task<List<AllEventsViewModel>> MyJoinedEvents(string userId);
		Task RemoveEvent(Event e);
		Task EditEventAsync(Event e, AddEventViewModel viewModel);
	}
}
