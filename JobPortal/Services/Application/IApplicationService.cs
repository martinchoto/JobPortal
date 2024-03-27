using JobPortal.Core.Data.Models;
using JobPortal.ViewModels.Application;

namespace JobPortal.Services.Application
{
	public interface IApplicationService
	{
		Task AddApplicationAsync(AddJobApplicationViewModel viewModel, string applicantId);
		Task<List<MyJobApplicationViewModel>> GetApplicationsAsync(string applicantId);
		Task<JobApplication> GetApplication(int id);
		Task<AddJobApplicationViewModel> BuildViewModel(JobApplication jobApplication);
		Task EditJobApplicationAsync(AddJobApplicationViewModel model, int id);
		Task<DeleteApplicationViewModel> BuildDeleteModelAsync(JobApplication jobApplication);
		Task DeleteApplicationAsync(JobApplication application);
		Task<DetailsApplicationViewModel> BuildDetailsViewModelAsync(JobApplication jobApp);
	}
}
