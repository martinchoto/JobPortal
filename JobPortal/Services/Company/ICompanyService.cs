using JobPortal.Core.Data.Models;
using JobPortal.ViewModels.Company;
using Microsoft.CodeAnalysis.Differencing;

namespace JobPortal.Services.Company
{
	public interface ICompanyService
	{

		Task<List<AllMyJobOffers>> GetAllJobOffersForCompanyAsync(string companyId);
		Task AddJobOfferAsync(AddJobOfferViewModel viewModel, string companyId);
		Task<List<TypesViewModel>> GetTypes();
		Task<JobOffer> GetOffer(int id);
		Task<AddJobOfferViewModel> BuildEditViewModel(int id);
		Task EditJobOfferAsync(AddJobOfferViewModel viewModel, int id, string companyId);
		Task DeleteJobOffer(JobOffer jobOffer);
	}
}
