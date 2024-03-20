using Job_Portal.Data;
using JobPortal.Core.Data.Models;
using JobPortal.ViewModels.Company;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Services.Company
{
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
				.Where(x => x.CompanyId == companyId)
				.Select(x => new AllMyJobOffers
				{
					Id = x.Id,
					Status = x.Status,
					VacationDays = x.VacationDays,
					Position = x.Position,
					Salary = x.Salary.ToString("0.##"),
				})
				.ToListAsync();
		}

		public async Task AddJobOfferAsync(AddJobOfferViewModel viewModel, string companyId)
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
		public async Task EditJobOfferAsync(AddJobOfferViewModel viewModel, int id, string companyId)
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
	}
}
