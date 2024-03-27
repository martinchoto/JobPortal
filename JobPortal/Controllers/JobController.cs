using JobPortal.Services.Job;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
		public async Task<IActionResult> All()
		{
			var jobs = await _jobService.AllJobsAsync();
			return View(jobs);
		}
		public async Task<IActionResult> Details(int id)
		{
			var job = await _jobService.FindJobAsync(id);
			if (job == null)
			{
				return BadRequest();
			}
			var jobViewModel = await _jobService.BuildDetailsViewModel(job, GetUserId());
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
			var companies = await _jobService.GetAllCompaniesAsync();
			return View(companies);
		}
		[Authorize(Roles = "Applicant")]
		public async Task<IActionResult> AllOffers(int id)
		{
			var companies = await _jobService.GetCompanyOffers(id);
			return View(companies);
		}
		private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
	}

}
