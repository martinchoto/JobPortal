using JobPortal.Core.Constants;
using JobPortal.Core.Data;
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
		public async Task<List<JobOffersViewModel>> AllJobsAsync()
		{
			var jobs = await _context.JobOffers
				.Select(x => new JobOffersViewModel
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

		public Task<bool> AlreadyAppliedForAJobAsync(int jobId, int applicationId)
		{
			return _context.JobOffersApplications.AnyAsync(x => x.ApplicationId
			== applicationId && x.JobOfferId == jobId);
		}

		public async Task<JobDetailsViewModel> BuildDetailsViewModel(JobOffer job, string userId)
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
				Email = job.Company.User.Email,
				ImageUrl = job.Company.LogoUrl,
				Address = job.Company.Address,
				CompanyName = job.Company.CompanyName,
				Description = job.Description,
				LastUpdatedOn = job.PostedDate.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture),
				Type = job.Type.Name,
				Applications = await GetAllApplicationsAsync(userId),
				UserId = userId,
			};
			return jobViewModel;
		}

		public async Task<JobOffer> FindJobAsync(int jobId)
		{
			return await _context.JobOffers.FindAsync(jobId);
		}

		public async Task<List<AllApplicationsViewModel>> GetAllApplicationsAsync(string userId)
		{
			var applications = await _context.Applications
				.Where(a => a.UserId == userId)
				.Select(x => new AllApplicationsViewModel
				{
					Id = x.Id,
					Name = x.Name
				})
				.ToListAsync();

			return applications;
		}
		public async Task AddJobApplicationToJobOfferAsync(int jobId, int applicationId)
		{
			JobOfferApplication job = new JobOfferApplication()
			{
				ApplicationId = applicationId,
				JobOfferId = jobId
			};

			await _context.JobOffersApplications.AddAsync(job);
			await _context.SaveChangesAsync();
		}
	}
}
