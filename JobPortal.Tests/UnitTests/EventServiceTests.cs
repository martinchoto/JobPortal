using JobPortal.Core.Data.Models;
using JobPortal.Services.Event;
using JobPortal.ViewModels.Event;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Tests.UnitTests
{
	[TestFixture]
	public class EventServiceTests : UnitTestsBase
	{
		private IEventService _eventService;
		private string userId = "018bff8a-5df3-40d8-8a65-e6a5e932f957";
		[OneTimeSetUp]
		public void SetUp()
		{
			_eventService = new EventService(_context);
		}
		[Test]
		public async Task AddEvent_Test()
		{
			Assert.AreEqual(6, _context.Events.Count());
			int companyId = 1;
			AddEventViewModel viewModel = new AddEventViewModel()
			{
				Name = "test",
				Description = "testdesc",
				Date = DateTime.UtcNow,
				ImageUrl = "asdImage"
			};

			await _eventService.AddEventAsync(companyId, viewModel);
			Assert.AreEqual(7, _context.Events.Count());
		}
		[Test]
		public async Task AllEvents_Test()
		{
			var allEventsServiceModel = await _eventService.All();

			Assert.AreEqual(_context.Events.Count(), allEventsServiceModel.TotalEventsCount);
		}
		[Test]
		public async Task AlreadyJoinedAndJoin_Test()
		{
			Assert.IsFalse(await _eventService.AlreadyJoinedEvent(userId, 5));
			EventParticipants ep = new EventParticipants()
			{
				ParticipantId = userId,
				EventId = 5
			};
			await _eventService.JoinEvent(ep);

			Assert.IsTrue(await _eventService.AlreadyJoinedEvent(userId, 5));
		}
		[Test]
		public async Task FindCompany_Test()
		{
			var company = await _eventService.FindCompanyByUserIdAsync("ba20f920-1a04-4d5b-8a7f-f0b0a328169d");
			Assert.IsNotNull(company);
			Assert.AreEqual(2, company.Id);
			Assert.AreEqual("Lidl", company.CompanyName);
			Assert.AreEqual("Sofia", company.Location);
			Assert.AreEqual("ul. Iordan Iosifov", company.Address);
			Assert.AreEqual("https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/Lidl-Logo.svg/150px-Lidl-Logo.svg.png", company.LogoUrl);

		}
		[Test]
		public async Task FindEventById_Test()
		{
			var e = await _eventService.GetEventAsync(7);
			Assert.IsNotNull(e);
			Assert.AreEqual("test", e.Name);
			Assert.AreEqual("testdesc", e.Description);
			Assert.AreEqual(DateTime.UtcNow.Year, e.Date.Year);
			Assert.AreEqual("asdImage", e.ImageUrl);
			Assert.AreEqual(1, e.CompanyId);
		}
		[Test]
		public async Task SearchEventParticipantsAndLeave_Test()
		{
			var ep = await _eventService.GetEventParticipantsByUserIdAsync(userId, 5);
			Assert.IsNotNull(ep);
			await _eventService.LeaveEvent(ep);

			Assert.IsFalse(await _eventService.AlreadyJoinedEvent(userId, 5));
		}
		[Test]
		public async Task MyJoinedEvents_Test()
		{
			EventParticipants ep = new EventParticipants()
			{
				ParticipantId = userId,
				EventId = 4
			};
			await _eventService.JoinEvent(ep);

			var events = await _eventService.MyJoinedEvents(userId);
			Assert.AreEqual(2, events.Count);
		}
		[Test]
		public async Task RemoveEvent_Test()
		{
			var e = await _eventService.GetEventAsync(7);

			await _eventService.RemoveEvent(e);
			e = await _eventService.GetEventAsync(7);
			Assert.IsNull(e);
		}
		[Test]	
		public async Task BuildDetails_Test()
		{
			var e = await _eventService.GetEventAsync(4);

			var detailsView = await _eventService.GetEventDetailsAsync(e);

			Assert.AreEqual(e.Name, detailsView.Name);
			Assert.AreEqual(e.Id, detailsView.Id);
			Assert.AreEqual(e.ImageUrl, detailsView.ImageUrl);
			Assert.AreEqual(e.Description, detailsView.Description);
			Assert.AreEqual(e.Company.Location, detailsView.Location);
			Assert.AreEqual(e.Company.Address, detailsView.Address);
			Assert.AreEqual(e.Company.CompanyName, detailsView.CompanyName);
		}
		[Test]
		public async Task EditEvent_Test()
		{
			AddEventViewModel viewModel = new AddEventViewModel()
			{
				Name = "testName",
				Description = "testDesc",
				Date = DateTime.UtcNow,
				ImageUrl = "asdImage"
			};
			var e = await _eventService.GetEventAsync(2);
			await _eventService.EditEventAsync(e, viewModel);

			Assert.AreEqual(viewModel.Name, e.Name);
			Assert.AreEqual(viewModel.Description, e.Description);
			Assert.AreEqual(viewModel.Date.Year, e.Date.Year);
			Assert.AreEqual(viewModel.ImageUrl, e.ImageUrl);
		}

	}
}
