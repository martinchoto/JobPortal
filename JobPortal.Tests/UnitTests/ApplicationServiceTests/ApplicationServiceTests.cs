using JobPortal.Core.Constants;
using JobPortal.Core.Data.Identity;
using JobPortal.Core.Data.Models;
using JobPortal.Pages.Admin;
using JobPortal.Services.Admin;
using JobPortal.Services.Application;
using JobPortal.ViewModels.Application;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Globalization;
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
		[Test]
		public async Task BuildApplicationViewModel_Test()
		{
			var applicationFromDb = await _applicationService.GetApplication(1);
			var application = await _applicationService.BuildViewModel(applicationFromDb);

			Assert.IsNotNull(application);
			Assert.AreEqual(application.FullName, applicationFromDb.FullName);
			Assert.AreEqual(application.Reasons, applicationFromDb.Reason);
			Assert.AreEqual(application.Email, applicationFromDb.Email);
			Assert.AreEqual(application.Description, applicationFromDb.Description);
		}
		[Test]
		public async Task GetAllApplications_Test()
		{
			string applicantId = "018bff8a-5df3-40d8-8a65-e6a5e932f957";

			var myApplicationsViewModel = await _applicationService.GetApplicationsAsync(applicantId);

			Assert.AreEqual(2, myApplicationsViewModel.Count);
			Assert.AreEqual("Application for Cashier", myApplicationsViewModel[0].Name);
			Assert.AreEqual(1, myApplicationsViewModel[0].Id);
		}
		[Test]
		public async Task BuildDeleteViewModel_Test()
		{
			var application = await _applicationService.GetApplication(1);

			var viewModel = await _applicationService.BuildDeleteModelAsync(application);

			Assert.IsNotNull(viewModel);
			Assert.AreEqual(application.Id, viewModel.Id);
			Assert.AreEqual(application.Name, viewModel.Name);
			Assert.AreEqual(application.CreatedOn.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture),
				viewModel.UpdatedOn);
		}
		[Test]
		public async Task DeleteApplication_Test()
		{
			var applicationOne = await _applicationService.GetApplication(1);
			var applicationTwo = await _applicationService.GetApplication(2);

			Assert.IsNotNull(applicationOne);
			Assert.IsNotNull(applicationTwo);
			Assert.IsFalse(applicationOne.JobOfferApplications.Any());
			await _applicationService.DeleteApplicationAsync(applicationTwo);

			applicationTwo = await _applicationService.GetApplication(2);
			Assert.IsNull(applicationTwo);
		}
		[Test]
		public async Task BuildDetailsApplication_Test()
		{
			var application = await _applicationService.GetApplication(1);
			var viewModel = await _applicationService.BuildDetailsViewModelAsync(application);

			Assert.IsNotNull(viewModel);
			Assert.IsNotNull(application);
			Assert.AreEqual(application.FullName, viewModel.FullName);
			Assert.AreEqual(application.Name, viewModel.Name);
			Assert.AreEqual(application.Description, viewModel.Description);
			Assert.AreEqual(application.Email, viewModel.Email);
			Assert.AreEqual(application.Reason, viewModel.Reasons);
		}
		[Test]
		public async Task EditApplication_Test()
		{
			var application = await _applicationService.GetApplication(1);
			var buildModel = await _applicationService.BuildViewModel(application);

			Assert.IsNotNull(buildModel);

			Assert.AreEqual(application.Name, buildModel.ApplicationName);

			buildModel.ApplicationName = "asd";
			buildModel.FullName = "Test";
			buildModel.Reasons = "tests";
			buildModel.Description = "TestLOl";
			buildModel.Email = "TestEmail";

			await _applicationService.EditJobApplicationAsync(buildModel, 1);
			application = await _applicationService.GetApplication(1);

			Assert.AreEqual(buildModel.ApplicationName, application.Name);
			Assert.AreEqual(buildModel.FullName, application.FullName);
			Assert.AreEqual(buildModel.Reasons, application.Reason);
			Assert.AreEqual(buildModel.Description, application.Description);
			Assert.AreEqual(buildModel.Email, application.Email);
		}
	}
}
