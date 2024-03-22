using Job_Portal.Data;
using JobPortal.Core.Constants;
using JobPortal.Services.Job;
using JobPortal.ViewModels.Job;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
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
			var jobViewModel = await _jobService.BuildDetailsViewModel(job);
			return View(jobViewModel);
		}
	}
}
