using JobPortal.Core.Data.Models;
using JobPortal.ViewModels.Job;

namespace JobPortal.Services.Job
{
	public interface IJobService
	{
		public Task<List<AllJobsViewModel>> AllJobsAsync();
		public Task<JobOffer> FindJobAsync(int jobId);
		public Task<JobDetailsViewModel> BuildDetailsViewModel(JobOffer jobOffer);
	}
}
