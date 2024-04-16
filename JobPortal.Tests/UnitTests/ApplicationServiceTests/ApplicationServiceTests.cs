using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using JobPortal.Services.Admin;
using JobPortal.Services.Application;
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
			JobApplication jobApplication = new JobApplication()
			{
				Name = "Test",
				FullName = "Test, Test",
				Description = "TestDesc",
				Email = "Test@abv.bg",
				Reason = "asdReason",
				UserId = "123456"
			};
			_context.Applications.Add(jobApplication);
			_context.SaveChanges();
			applicationsCount = _context.Applications.Count();
			Assert.IsNotNull(jobApplication);
			Assert.AreEqual(jobApplication.Name, "Test");
			Assert.AreEqual(jobApplication.FullName, "Test, Test");
			Assert.AreEqual(jobApplication.Description, "TestDesc");
			Assert.AreEqual(jobApplication.Email, "Test@abv.bg");
			Assert.AreEqual(jobApplication.UserId, "123456");
			Assert.AreEqual(applicationsCount, 3);
		}
	}
}
