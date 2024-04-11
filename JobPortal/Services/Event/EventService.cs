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
	using JobPortal.Services.Event.Models;
	using JobPortal.Core.Enums;
	using JobPortal.Core.Data.Enums;
	using JobPortal.Services.Job.Models;

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

		public async Task<EventQueryServiceModel> All(string searchTerm = null,
			EventSorting sorting = EventSorting.Newest,
			int currentPage = 1,
			int eventsPerPage = 1)
		{
			var eventsQuery = _context.Events.AsQueryable();



			if (!string.IsNullOrEmpty(searchTerm))
			{
				eventsQuery = eventsQuery.Where(e =>
						e.Name.ToLower().Contains(searchTerm.ToLower()) ||
						e.Company.CompanyName.ToLower().Contains(searchTerm.ToLower()) ||
						e.Description.ToLower().Contains(searchTerm.ToLower()) ||
						e.Company.Location.ToLower().Contains(searchTerm.ToLower()));
			}
			eventsQuery = sorting switch
			{
				EventSorting.Newest => eventsQuery
					.OrderByDescending(j => j.Id),
				EventSorting.Ascending => eventsQuery
					.OrderBy(j => j.Date),
				EventSorting.Descending => eventsQuery
					.OrderByDescending(j => j.Date),
				_ => eventsQuery.OrderBy(x => x.Id)
			};

			var skipAmount = (currentPage - 1) * eventsPerPage;
			var events = await eventsQuery
				.Skip(skipAmount)
				.Take(eventsPerPage)
				.Select(x => new EventServiceModel
				{
					Id = x.Id,
					Name = x.Name,
					CompanyName	= x.Company.CompanyName,
					Date = x.Date.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture),
					ImageUrl = x.ImageUrl,
					OwnerId = x.Company.UserId
				})
				.ToListAsync();

			var totalEvents = eventsQuery.Count();

			return new EventQueryServiceModel()
			{
				TotalEventsCount = totalEvents,
				Events = events,
			};
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
					OwnerId = e.Company.UserId,
					CompanyName = e.Company.CompanyName
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
				.OrderBy(x => x.Event.Date)
				.Select(e => new AllEventsViewModel
				{
					Id = e.EventId,
					Name = e.Event.Name,
					Date = e.Event.Date.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture),
					ImageUrl = e.Event.ImageUrl,
					CompanyName = e.Event.Company.CompanyName
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
