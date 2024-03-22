using Job_Portal.Data;
using JobPortal.Core.Constants;
using JobPortal.ViewModels.Job;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
	public class JobController : Controller
	{
		private readonly JobPortalDbContext jobPortalDbContext;
		public JobController(JobPortalDbContext jobPortalDbContext)
		{
			this.jobPortalDbContext = jobPortalDbContext;
		}
		public async Task<IActionResult> All()
		{
			var jobs = jobPortalDbContext.JobOffers
				.Select(x => new AllJobsViewModel
				{
					Id = x.Id,
					Position = x.Position,
					Status = x.Status,
					Salary = x.Salary.ToString(DataConstants.DECIMAL_FORMAT),
					VacationDays = x.VacationDays,
					ImageUrl = x.Company.LogoUrl
				})
				.ToList();
			return View(jobs);
		}
		public async Task<IActionResult> Details(int id)
		{
			var job = await jobPortalDbContext.JobOffers
				.FindAsync(id);
			if (job == null)
			{
				return BadRequest();
			}
			var jobViewModel = new JobDetailsViewModel
			{
				Id = job.Id,
				Status = job.Status,
				Position = job.Position,
				Salary = job.Salary.ToString(DataConstants.DECIMAL_FORMAT),
				VacationDays = job.VacationDays,
				Bonus = job.Bonus,
				Location = job.Company.Location,
				Email = job.Company.Email,
				ImageUrl = job.Company.LogoUrl,
				Address = job.Company.Address,
				CompanyName = job.Company.CompanyName,
				Description = job.Description,
				LastUpdatedOn = job.PostedDate.ToString("dd/MM/yyyy")
			};
			return View(jobViewModel);
		}
	}
}
