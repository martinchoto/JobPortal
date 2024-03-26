
using JobPortal.ViewModels.Company;
using Microsoft.CodeAnalysis.Differencing;

namespace JobPortal.Services.Company
{
	using JobPortal.Core.Data.Models;
	public interface ICompanyService
	{

		Task<List<AllMyJobOffers>> GetAllJobOffersForCompanyAsync(string companyId);
		Task AddJobOfferAsync(AddJobOfferViewModel viewModel, int companyId);
		Task<List<TypesViewModel>> GetTypes();
		Task<JobOffer> GetOffer(int id);
		Task<AddJobOfferViewModel> BuildEditViewModel(int id);
		Task EditJobOfferAsync(AddJobOfferViewModel viewModel, int id);
		Task DeleteJobOffer(JobOffer jobOffer);
		Task<Company> CompanyAsync(string companyId);
	}
}
