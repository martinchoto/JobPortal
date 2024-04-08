using JobPortal.Core.Data.Models;
using JobPortal.Services.Event;
using JobPortal.ViewModels.Event;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JobPortal.Controllers
{
	[Authorize]
	public class EventController : Controller
	{
		private readonly IEventService _eventService;
		public EventController(IEventService eventService)
		{
			_eventService = eventService;
		}

		public async Task<IActionResult> All()
		{
			List<AllEventsViewModel> viewModel = await _eventService.GetAllEventsAsync();
			return View(viewModel);
		}
		[Authorize(Roles = "Company")]
		[HttpGet]
		public async Task<IActionResult> Add()
		{
			AddEventViewModel viewModel = new AddEventViewModel();
			return View(viewModel);
		}
		[Authorize(Roles = "Company")]
		[HttpPost]
		public async Task<IActionResult> Add(AddEventViewModel viewModel)
		{
			Company company = await _eventService.FindCompanyByUserIdAsync(GetUserId());

			if (company == null)
			{
				return BadRequest();
			}
			if (!ModelState.IsValid)
			{
				return View(viewModel);
			}
			await _eventService.AddEventAsync(company.Id, viewModel);
			return RedirectToAction(nameof(All), "Event");
		}
		public async Task<IActionResult> Details(int id, string info)
		{
			Event e = await _eventService.GetEventAsync(id);

			if (e == null)
			{
				return BadRequest();
			}
			EventDetailsViewModel viewModel = await _eventService.GetEventDetailsAsync(e);
			return View(viewModel);
		}
		[Authorize(Roles = "Applicant")]
		public async Task<IActionResult> Join(int id)
		{
			if (await _eventService.AlreadyJoinedEvent(GetUserId(), id))
			{
				return RedirectToAction(nameof(Joined), "Event");
			}
			EventParticipants ep = new EventParticipants()
			{
				ParticipantId = GetUserId(),
				EventId = id
			};
			await _eventService.JoinEvent(ep);
			return RedirectToAction(nameof(Joined), "Event");
		}
		[Authorize(Roles = "Applicant")]
		public async Task<IActionResult> Joined()
		{
			List<AllEventsViewModel> viewModel = await _eventService.MyJoinedEvents(GetUserId());
			return View(viewModel);
		}
		[Authorize(Roles = "Applicant")]
		public async Task<IActionResult> Leave(int id)
		{
			EventParticipants ep = await _eventService.GetEventParticipantsByUserIdAsync(GetUserId(), id);

			if (ep == null)
			{
				return BadRequest();
			}
			await _eventService.LeaveEvent(ep);
			return RedirectToAction(nameof(Joined), "Event");
		}
		[Authorize(Roles = "Company,Admin")]
		public async Task<IActionResult> Delete(int id)
		{
			Event e = await _eventService.GetEventAsync(id);
			if (e == null)
			{
				return BadRequest();
			}
			if (e.Company.UserId != GetUserId() && !User.IsInRole("Admin"))
			{
				return Unauthorized();
			}
			await _eventService.RemoveEvent(e);
			return RedirectToAction(nameof(All), "Event");
		}
		[Authorize(Roles = "Company,Admin")]
		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			Event e = await _eventService.GetEventAsync(id);
			if (e == null)
			{
				return BadRequest();
			}
			if (e.Company.UserId != GetUserId() && !User.IsInRole("Admin"))
			{
				return Unauthorized();
			}
			AddEventViewModel editViewModel = new AddEventViewModel()
			{
				Name = e.Name,
				Date = e.Date,
				Description = e.Description,
				ImageUrl = e.ImageUrl,
			};
			return View(editViewModel);

		}
		[Authorize(Roles = "Company,Admin")]
		[HttpPost]
		public async Task<IActionResult> Edit(int id, AddEventViewModel viewModel)
		{
			Event e = await _eventService.GetEventAsync(id);
			if (e == null)
			{
				return BadRequest();
			}
			if (e.Company.UserId != GetUserId() && !User.IsInRole("Admin"))
			{
				return Unauthorized();
			}
			if (!ModelState.IsValid)
			{
				return View(viewModel);
			}
			await _eventService.EditEventAsync(e, viewModel);
			return RedirectToAction(nameof(All), "Event");
		}
		private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
	}
}
