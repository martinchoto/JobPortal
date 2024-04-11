using JobPortal.Core.Constants;
using JobPortal.Core.Data;
using JobPortal.Core.Data.Models;
using JobPortal.Core.Enums;
using JobPortal.Services.Job.Models;
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
				UserId = job.Company.UserId
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

		public async Task<List<AllCompaniesViewModel>> GetAllCompaniesAsync()
		{
			return await _context.Companies
				.Select(x => new AllCompaniesViewModel
				{
					Id = x.Id,
					Name = x.CompanyName,
					ImageUrl = x.LogoUrl
				})
				.ToListAsync();
		}

		public async Task<List<JobServiceModel>> GetCompanyOffers(int id)
		{
			return await _context.JobOffers
				.Where(x => x.CompanyId == id)
				.Select(x => new JobServiceModel
				{
					Id = x.Id,
					ImageUrl = x.Company.LogoUrl,
					VacationDays = x.VacationDays,
					Position = x.Position,
					Salary = decimal.Parse(x.Salary.ToString(DataConstants.DECIMAL_FORMAT)),
					Status = x.Status,
					Type = x.Type.Name,
					CompanyName = x.Company.CompanyName
				})
				.ToListAsync();
		}

		public async Task<JobQueryServiceModel> All(string type = null,
			string searchTerm = null,
			JobSorting sorting = JobSorting.Newest,
			int currentPage = 1,
			int jobsPerPage = 1)
		{
			var jobsQuery = _context.JobOffers.AsQueryable();

			if (!string.IsNullOrEmpty(type))
			{
				jobsQuery = _context.JobOffers
					.Where(j => j.Type.Name.ToLower() == type.ToLower());
			}

			if (!string.IsNullOrEmpty(searchTerm))
			{
				jobsQuery = jobsQuery.Where(j =>
						j.Position.ToLower().Contains(searchTerm.ToLower()) ||
						j.Company.CompanyName.ToLower().Contains(searchTerm.ToLower()) ||
						j.Description.ToLower().Contains(searchTerm.ToLower()));
			}

			jobsQuery = sorting switch
			{
				JobSorting.Newest => jobsQuery
					.OrderByDescending(j => j.Id),
				JobSorting.Oldest => jobsQuery
					.OrderBy(j => j.Id),
				JobSorting.LowestSalary => jobsQuery
					.OrderBy(j => j.Salary),
				JobSorting.HighestSalary => jobsQuery
					.OrderByDescending(j => j.Salary),
					_ => jobsQuery.OrderBy(x => x.Id)
			} ;

			var skipAmount = (currentPage - 1) * jobsPerPage;
			var jobs = await jobsQuery
				.Skip(skipAmount)
				.Take(jobsPerPage)
				.Select(x => new JobServiceModel
				{
					Id = x.Id,
					VacationDays = x.VacationDays,
					Position = x.Position,
					Salary = decimal.Parse(x.Salary.ToString(DataConstants.DECIMAL_FORMAT)),
					ImageUrl = x.Company.LogoUrl,
					CompanyName = x.Company.CompanyName,
					Status = x.Status,
					Type = x.Type.Name
				})
				.ToListAsync();

			var totalJobs = jobsQuery.Count();

			return new JobQueryServiceModel()
			{
				TotalJobsCount = totalJobs,
				Jobs = jobs,
			};
		}

		public async Task<List<string>> AllTypes()
		{
			return await _context.Types
				.Select(x => x.Name)
				.ToListAsync();
		}
	}
}
