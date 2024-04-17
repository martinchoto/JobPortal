using JobPortal.Core.Data.Models;
using JobPortal.Services.Company;
using JobPortal.ViewModels.Company;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Tests.UnitTests
{
	[TestFixture]
	public class CompanyServiceTests : UnitTestsBase
	{
		private const string userId = "ba20f920-1a04-4d5b-8a7f-f0b0a328169d";
		private ICompanyService _companyService;
		[OneTimeSetUp]
		public void SetUp()
		{
			_companyService = new CompanyService(_context);
		}
		[Test]
		public async Task AddJobOffer_Test()
		{
			var company = await _companyService.FindCompanyByUserId(userId);
			Assert.IsNotNull(company);
			Assert.AreEqual(userId, company.UserId);
			var jobOffers = await _companyService.GetAllJobOffersForCompanyAsync(userId);
			Assert.AreEqual(3, jobOffers.Count);

			AddJobOfferViewModel viewModel = new AddJobOfferViewModel()
			{
				Bonus = "asdBonus",
				Description = "DescriptionTest",
				VacationDays = 1,
				Position = "ceoTEST",
				Salary = 1400M,
				Status = "OK",
				TypeId = 1
			};

			await _companyService.AddJobOfferAsync(viewModel, company.Id);
			jobOffers = await _companyService.GetAllJobOffersForCompanyAsync(userId);
			Assert.AreEqual(4, jobOffers.Count);
		}
		[Test]
		public async Task EditJobOffer_Test()
		{
			var viewModel = await _companyService.BuildEditViewModel(4);
			await _companyService.EditJobOfferAsync(viewModel,4);

			var jobOffers = await _companyService.GetOffer(4);
			Assert.IsNotNull(viewModel);

			Assert.AreEqual(viewModel.Status, jobOffers.Status);
			Assert.AreEqual(viewModel.Description, jobOffers.Description);
			Assert.AreEqual(viewModel.TypeId, jobOffers.TypeId);
			Assert.AreEqual(viewModel.Salary, jobOffers.Salary);
			Assert.AreEqual(viewModel.VacationDays, jobOffers.VacationDays);
			Assert.AreEqual(viewModel.Bonus, jobOffers.Bonus);
		}
		[Test]
		public async Task Types_Test()
		{
			var types = await _companyService.GetTypes();

			Assert.AreEqual(_context.Types.Count(), types.Count);
			Assert.IsTrue(types.Any());
		}
		[Test]
		public async Task DeleteJobOffer_Test()
		{
			var jobOffer = await _companyService.GetOffer(1);
			Assert.IsNotNull(jobOffer);
			await _companyService.DeleteJobOffer(jobOffer);
			jobOffer = await _companyService.GetOffer(1);
			Assert.IsNull(jobOffer);
		}
		[Test]
		public async Task GetApplicationsForJob_Test()
		{
			var applications = await _companyService.GetAllApplicationsForJobOffers(1);
			Assert.IsFalse(applications.Any());
			await AddJobOfferToContext();
			applications = await _companyService.GetAllApplicationsForJobOffers(1);
			Assert.IsTrue(applications.Any());

		}
		private async Task AddJobOfferToContext()
		{
			JobOfferApplication ja = new JobOfferApplication()
			{
				JobOfferId = 1,
				ApplicationId = 1
			};
			await _context.JobOffersApplications.AddAsync(ja);
			await _context.SaveChangesAsync();
		}
		[Test]
		public async Task DeleteApplicationsForJob_Test()
		{
			await AddJobOfferToContext();
			var application = await _companyService.GetJobOfferApplication(1, 1);

			var viewModel = await _companyService.DetailsBuildViewModel(application);

			Assert.IsNotNull(viewModel);

			Assert.AreEqual(application.Application.Reason, viewModel.Reasons);
			Assert.AreEqual(application.Application.Name, viewModel.Name);
			Assert.AreEqual(application.Application.FullName, viewModel.FullName);
			Assert.AreEqual(application.Application.Description, viewModel.Description);
			Assert.AreEqual(application.Application.Email, viewModel.Email);

			Assert.IsNotNull(application);

			await _companyService.DeleteApplication(application);
			await _companyService.GetJobOfferApplication(1, 1);

			application = await _companyService.GetJobOfferApplication(1, 1);
			Assert.IsNull(application);
		}
		
	}
}
