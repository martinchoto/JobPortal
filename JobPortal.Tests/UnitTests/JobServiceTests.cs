using JobPortal.Services.Job;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Tests.UnitTests
{
	[TestFixture]
	public class JobServiceTests : UnitTestsBase
	{
		private IJobService _jobService;
		private const string companyUserId = "d79e6d15-bed9-45f6-8d00-6a506474f385";
		private const string normalUserId = "018bff8a-5df3-40d8-8a65-e6a5e932f957";
		[OneTimeSetUp]
		public void SetUp()
		{
			_jobService = new JobService(_context);
		}
		[Test]
		public async Task FindJobOffer_Test()
		{
			var jobOffer = await _jobService.FindJobAsync(1);
			Assert.IsNotNull(jobOffer);

			var detailsJobOffer = await _jobService.BuildDetailsViewModel(jobOffer, companyUserId);
			Assert.IsNotNull(detailsJobOffer);
			Assert.AreEqual(jobOffer.Id, detailsJobOffer.Id);
			Assert.AreEqual(jobOffer.Salary.ToString(), detailsJobOffer.Salary);
			Assert.AreEqual(jobOffer.Description, detailsJobOffer.Description);
			Assert.AreEqual(jobOffer.Status, detailsJobOffer.Status);
			Assert.AreEqual(jobOffer.VacationDays, detailsJobOffer.VacationDays);
			Assert.AreEqual(jobOffer.Type.Name, detailsJobOffer.Type);
			Assert.AreEqual(jobOffer.Position, detailsJobOffer.Position);
			Assert.AreEqual(jobOffer.Company.Location, detailsJobOffer.Location);
			Assert.AreEqual(jobOffer.Company.User.Email, detailsJobOffer.Email);
			Assert.AreEqual(jobOffer.Company.LogoUrl, detailsJobOffer.ImageUrl);
			Assert.AreEqual(jobOffer.Company.Address, detailsJobOffer.Address);
			Assert.AreEqual(jobOffer.Company.CompanyName, detailsJobOffer.CompanyName);
			Assert.AreEqual(jobOffer.Company.UserId, detailsJobOffer.UserId);
		}
		[Test]
		public async Task AlreadyApplied_Tests()
		{
			var result = await _jobService.AlreadyAppliedForAJobAsync(1, 1);
			Assert.IsFalse(result);

			await _jobService.AddJobApplicationToJobOfferAsync(1, 1);
			result = await _jobService.AlreadyAppliedForAJobAsync(1, 1);
			Assert.IsTrue(result);
		}
		[Test]
		public async Task GetAllMyApplications_Test()
		{
			var result = await _jobService.GetAllApplicationsAsync(normalUserId);
			var context = _context.Applications.Where(x=> x.UserId == normalUserId).ToList();
			Assert.AreEqual(context.Count, result.Count);
			Assert.IsTrue(result.Any());
		}
		[Test]
		public async Task GetAllCompanies_Test()
		{
			var companies = _context.Companies.ToList();
			var resultFromService = await _jobService.GetAllCompaniesAsync();

			Assert.AreEqual(companies.Count, resultFromService.Count);
		}
		[Test]
		public async Task GetJobOffersFromCompany_Test()
		{
			var jobOffers = await _jobService.GetCompanyOffers(2);
			var contextOffers = _context.JobOffers.Where(x => x.CompanyId == 2).ToList();
			Assert.AreEqual(contextOffers.Count, jobOffers.Count);
		}
		[Test]
		public async Task AllJobOffersAndTypes_Tests()
		{
			var jobOffers = await _jobService.All();
			var jobOffersFromContext = await _context.JobOffers.ToListAsync();

			Assert.AreEqual(jobOffersFromContext.Count, jobOffers.TotalJobsCount);

			var types = await _jobService.AllTypes();

			var typesFromContext = await _context.Types.Select(x => x.Name).ToListAsync();

			Assert.AreEqual(types.Count, typesFromContext.Count);
			Assert.AreEqual(types, typesFromContext);
		}
	}

}
