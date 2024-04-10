namespace JobPortal.Services.Job
{
    using JobPortal.Core.Data.Models;
    using JobPortal.Services.Job.Models;
    using JobPortal.ViewModels.Job;
    using JobPortal.Core.Enums;

    public interface IJobService
	{
		Task<JobOffer> FindJobAsync(int jobId);
		Task<JobDetailsViewModel> BuildDetailsViewModel(JobOffer jobOffer, string userId);
		Task<bool> AlreadyAppliedForAJobAsync(int jobId, int applicationId);
		Task<List<AllApplicationsViewModel>> GetAllApplicationsAsync(string userId);
		Task AddJobApplicationToJobOfferAsync(int jobId, int applicationId);
		Task<List<AllCompaniesViewModel>> GetAllCompaniesAsync();
		Task<List<JobServiceModel>> GetCompanyOffers(int id);
		Task<JobQueryServiceModel> All(string type = null, string searchTerm = null, 
			JobSorting sorting = JobSorting.Newest, int currentPage = 1, int jobsPerPage = 1);
		Task<List<string>> AllTypes();
	}
}
