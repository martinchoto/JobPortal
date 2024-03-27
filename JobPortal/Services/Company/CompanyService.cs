using JobPortal.Core.Constants;
using JobPortal.Core.Data;
using JobPortal.ViewModels.Company;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace JobPortal.Services.Company
{
	using JobPortal.Core.Data.Models;
	using JobPortal.ViewModels.Application;
	

	public class CompanyService : ICompanyService
	{
		private readonly JobPortalDbContext _context;

		public CompanyService(JobPortalDbContext context)
		{
			_context = context;
		}

		public async Task<List<AllMyJobOffers>> GetAllJobOffersForCompanyAsync(string companyId)
		{
			return await _context.JobOffers
				.Where(x => x.Company.UserId == companyId)
				.Select(x => new AllMyJobOffers
				{
					Id = x.Id,
					Status = x.Status,
					VacationDays = x.VacationDays,
					Position = x.Position,
					Salary = x.Salary.ToString(DataConstants.DECIMAL_FORMAT),
					Type = x.Type.Name
				})
				.ToListAsync();
		}

		public async Task AddJobOfferAsync(AddJobOfferViewModel viewModel, int companyId)
		{
			var jobOffer = new JobOffer
			{
				Position = viewModel.Position,
				Status = viewModel.Status,
				Description = viewModel.Description,
				Bonus = viewModel.Bonus,
				Salary = viewModel.Salary,
				VacationDays = viewModel.VacationDays,
				TypeId = viewModel.TypeId,
				CompanyId = companyId,
				PostedDate = DateTime.UtcNow
			};

			await _context.JobOffers.AddAsync(jobOffer);
			await _context.SaveChangesAsync();
		}

		public async Task<List<TypesViewModel>> GetTypes()
		{
			return await _context.Types
				.Select(x => new TypesViewModel
				{
					Id = x.Id,
					Name = x.Name,
				})
				.ToListAsync();
		}
		public async Task<JobOffer> GetOffer(int id)
		{
			return await _context.JobOffers.FindAsync(id);
		}
		public async Task<AddJobOfferViewModel> BuildEditViewModel(int id)
		{
			var edited = await GetOffer(id);
			var types = await GetTypes();

			return new AddJobOfferViewModel()
			{
				Position = edited.Position,
				Status = edited.Status,
				Salary = edited.Salary,
				Description = edited.Description,
				VacationDays = edited.VacationDays,
				Types = types,
				TypeId = edited.TypeId,
				Bonus = edited.Bonus
			};
		}
		public async Task EditJobOfferAsync(AddJobOfferViewModel viewModel, int id)
		{
			var toBeEdited = await GetOffer(id);
			toBeEdited.Status = viewModel.Status;
			toBeEdited.Position = viewModel.Position;
			toBeEdited.Description = viewModel.Description;
			toBeEdited.Salary = viewModel.Salary;
			toBeEdited.TypeId = viewModel.TypeId;
			toBeEdited.Bonus = viewModel.Bonus;
			toBeEdited.PostedDate = DateTime.UtcNow;
			toBeEdited.VacationDays = viewModel.VacationDays;

			await _context.SaveChangesAsync();
		}

		public async Task DeleteJobOffer(JobOffer jobOffer)
		{
			if (jobOffer.JobOfferApplications.Any())
			{
				jobOffer.JobOfferApplications.Clear();

			}
			_context.JobOffers.Remove(jobOffer);
			await _context.SaveChangesAsync();
		}
		public async Task<Company> CompanyAsync(string companyId)
		{
			return await _context.Companies.FirstOrDefaultAsync(x => x.UserId == companyId);
		}

		public async Task<List<MyJobApplicationViewModel>> GetAllApplicationsForJobOffers(int id)
		{
			List<MyJobApplicationViewModel> allJobs = await _context.JobOffersApplications
				.Where(x => x.JobOfferId == id)
				.Select(x => new MyJobApplicationViewModel
				{
					Id = x.ApplicationId,
					Name = x.Application.Name,
					CreatedOn = x.Application.CreatedOn.ToString(DataConstants.DATE_FORMAT, 
					CultureInfo.InvariantCulture),
				})
				.ToListAsync();

			return allJobs;
		}
		public async Task<JobOfferApplication> GetApplicationById(int id)
		{
			return await _context.JobOffersApplications.FirstOrDefaultAsync(x => x.ApplicationId == id);
		}

		public async Task DeleteApplication(JobOfferApplication jobOfferApplication)
		{
			_context.JobOffersApplications.Remove(jobOfferApplication);
			await _context.SaveChangesAsync();
		}

		public async Task<DetailsApplicationViewModel> DetailsBuildViewModel(JobOfferApplication jobApplication)
		{
			DetailsApplicationViewModel viewModel = new DetailsApplicationViewModel()
			{
				Name = jobApplication.Application.Name,
				Description = jobApplication.Application.Description,
				Email = jobApplication.Application.Email,
				FullName = jobApplication.Application.FullName,
				Reasons = jobApplication.Application.Reason
			};

			return viewModel;
		}
	}
}
