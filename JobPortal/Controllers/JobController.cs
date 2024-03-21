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
			return View();
		}
	}
}
