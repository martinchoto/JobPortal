using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using JobPortal.Services.Admin;
using JobPortal.Services.Application;
using JobPortal.ViewModels.Application;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Tests.UnitTests.ApplicationServiceTests
{
	[TestFixture]
	public class ApplicationServiceTests : UnitTestsBase
	{
		private IApplicationService _applicationService;
		[OneTimeSetUp]
		public void SetUp()
		{
			_applicationService = new ApplicationService(_context);
		}
		[Test]
		public async Task AddJobApplication_Test()
		{
			var applicationsCount = _context.Applications.Count();
            Assert.AreEqual(2, applicationsCount);
			AddJobApplicationViewModel jobApplication = new AddJobApplicationViewModel()
			{
				ApplicationName = "Test",
				FullName = "Test, Test",
				Description = "TestDesc",
				Email = "Test@abv.bg",
				Reasons = "asdReason",

			};
			_applicationService.AddApplicationAsync(jobApplication, "1234");
			applicationsCount = _context.Applications.Count();
			Assert.IsNotNull(jobApplication);
			Assert.AreEqual("Test", jobApplication.ApplicationName);
			Assert.AreEqual("Test, Test", jobApplication.FullName);
			Assert.AreEqual("TestDesc", jobApplication.Description);
			Assert.AreEqual("Test@abv.bg", jobApplication.Email);
			Assert.AreEqual("asdReason", jobApplication.Reasons);
			Assert.AreEqual(3, applicationsCount);
		}
		[Test]
		public async Task GetApplicationById_Test()
		{
			var application = await _applicationService.GetApplication(1);

			Assert.IsNotNull(application);
			Assert.AreEqual(1, application.Id);
			Assert.AreEqual("Application for Cashier", application.Name);
			Assert.AreEqual("Martin Stalev", application.FullName);
			Assert.AreEqual("martoplays@abv.bg", application.Email);
		}
	}
}
