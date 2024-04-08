namespace JobPortal.Services.Event
{
	using JobPortal.Core.Data;
	using JobPortal.Core.Constants;
	using JobPortal.Core.Data.Models;
	using JobPortal.ViewModels.Event;
	using Microsoft.EntityFrameworkCore;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using System.Globalization;

	public class EventService : IEventService
	{
		private readonly JobPortalDbContext _context;
		public EventService(JobPortalDbContext context)
		{
			_context = context;
		}
		public async Task AddEventAsync(int companyId, AddEventViewModel viewModel)
		{
			Event e = new Event()
			{
				Name = viewModel.Name,
				Description = viewModel.Description,
				CompanyId = companyId,
				Date = viewModel.Date,
				ImageUrl = viewModel.ImageUrl
			};
			await _context.Events.AddAsync(e);
			await _context.SaveChangesAsync();
		}

		public async Task<bool> AlreadyJoinedEvent(string userId, int eventId)
		{
			return await _context.EventsParticipants.AnyAsync(x => x.EventId == eventId && x.ParticipantId == userId);
		}

		public async Task EditEventAsync(Event e, AddEventViewModel viewModel)
		{
			e.Date = viewModel.Date;
			e.ImageUrl = viewModel.ImageUrl;
			e.Name = viewModel.Name;
			e.Description = viewModel.Description;
			await _context.SaveChangesAsync();
		}

		public async Task<Company> FindCompanyByUserIdAsync(string userId)
		{
			return await _context.Companies.FirstOrDefaultAsync(c => c.UserId == userId);
		}

		public async Task<List<AllEventsViewModel>> GetAllEventsAsync()
		{
			return await _context.Events
				.Select(e => new AllEventsViewModel
				{
					Id = e.Id,
					Name = e.Name,
					Date = e.Date.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture),
					ImageUrl = e.ImageUrl,
					OwnerId = e.Company.UserId
				})
				.ToListAsync();
		}

		public async Task<Event> GetEventAsync(int eventId)
		{
			return await _context.Events.FindAsync(eventId);
		}

		public async Task<EventDetailsViewModel> GetEventDetailsAsync(Event e)
		{
			return new EventDetailsViewModel()
			{
				Id = e.Id,
				Name = e.Name,
				DateTime = e.Date.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture),
				ImageUrl = e.ImageUrl,
				Description = e.Description,
				Location = e.Company.Location,
				Address = e.Company.Address,
				CompanyName = e.Company.CompanyName
			};
		}

		public async Task<EventParticipants> GetEventParticipantsByUserIdAsync(string userId, int eventId)
		{
			return await _context.EventsParticipants.FirstOrDefaultAsync(x => x.ParticipantId == userId && x.EventId == eventId);
		}

		public async Task JoinEvent(EventParticipants eventParticipants)
		{
			await _context.EventsParticipants.AddAsync(eventParticipants);
			await _context.SaveChangesAsync();
		}

		public async Task LeaveEvent(EventParticipants ep)
		{
			_context.EventsParticipants.Remove(ep);
			await _context.SaveChangesAsync();
		}

		public async Task<List<AllEventsViewModel>> MyJoinedEvents(string userId)
		{
			return await _context.EventsParticipants
				.Where(x => x.ParticipantId == userId)
				.Select(e => new AllEventsViewModel
				{
					Id = e.EventId,
					Name = e.Event.Name,
					Date = e.Event.Date.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture),
					ImageUrl = e.Event.ImageUrl,
				})
				.ToListAsync();
		}

		public async Task RemoveEvent(Event e)
		{
			if (e.EventParticipants.Any())
			{
				e.EventParticipants.Clear();
			}
			_context.Events.Remove(e);
			await _context.SaveChangesAsync();
		}
	}
}
