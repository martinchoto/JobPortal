using JobPortal.Core.Data.Models;
using JobPortal.Core.Enums;
using JobPortal.Services.Job;
using JobPortal.Services.Job.Models;
using JobPortal.ViewModels.Company;
using JobPortal.ViewModels.Job;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Security.Claims;

namespace JobPortal.Controllers
{
	[Authorize]
	public class JobController : Controller
	{
		private readonly IJobService _jobService;
		public JobController(IJobService jobService)
		{
			_jobService = jobService;
		}
		public async Task<IActionResult> All([FromQuery] AllJobsQueryViewModel query)
		{
			if (query.JobsPerPage != 3)
			{
				return RedirectToAction("All", "Job", new { jobsPerPage = 3, sorting = 0 });
			}
			var queryResult = await _jobService.All(
				query.Type,
				query.SearchTerm,
				query.JobSorting,
				query.CurrentPage,
				query.JobsPerPage);

			query.TotalJobsCount = queryResult.TotalJobsCount;
			query.Jobs = queryResult.Jobs;
			query.Types = await _jobService.AllTypes();

			return View(query);
		}
		public async Task<IActionResult> Details(int id, string info)
		{
			JobOffer job = await _jobService.FindJobAsync(id);
			if (job == null)
			{
				return BadRequest();
			}
			JobDetailsViewModel jobViewModel = await _jobService.BuildDetailsViewModel(job, GetUserId());
			return View(jobViewModel);
		}
		public async Task<JsonResult> Apply(int jobId, int applicationId)
		{
			if (await _jobService.AlreadyAppliedForAJobAsync(jobId, applicationId))
			{
				return Json(new { alreadyApplied = true });
			}

			await _jobService.AddJobApplicationToJobOfferAsync(jobId, applicationId);

			return Json(new { alreadyApplied = false });
		}
		[Authorize(Roles = "Applicant")]
		public async Task<IActionResult> AllCompanies()
		{
			List<AllCompaniesViewModel> companies = await _jobService.GetAllCompaniesAsync();
			return View(companies);
		}
		[Authorize(Roles = "Applicant")]
		public async Task<IActionResult> AllOffers(int id)
		{
			List<JobServiceModel> companies = await _jobService.GetCompanyOffers(id);
			return View(companies);
		}
		private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
	}

}
