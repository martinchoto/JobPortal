using Job_Portal.Data;
using JobPortal.Core.Constants;
using JobPortal.Core.Data.Models;
using JobPortal.ViewModels.Job;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace JobPortal.Services.Job
{
	public class JobService : IJobService
	{
		private readonly JobPortalDbContext _context;
		public JobService(JobPortalDbContext context)
		{
			_context = context;
		}
		public async Task<List<AllJobsViewModel>> AllJobsAsync()
		{
			var jobs = await _context.JobOffers
				.Select(x => new AllJobsViewModel
				{
					Id = x.Id,
					Position = x.Position,
					Status = x.Status,
					Salary = x.Salary.ToString(DataConstants.DECIMAL_FORMAT),
					VacationDays = x.VacationDays,
					ImageUrl = x.Company.LogoUrl,
					Type = x.Type.Name
				})
				.ToListAsync();
			return jobs;
		}

		public async Task<JobDetailsViewModel> BuildDetailsViewModel(JobOffer job)
		{
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
				LastUpdatedOn = job.PostedDate.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture),
				Type = job.Type.Name
			};
			return jobViewModel;
		}

		public async Task<JobOffer> FindJobAsync(int jobId)
		{
			return await _context.JobOffers.FindAsync(jobId);
		}
	}
}
