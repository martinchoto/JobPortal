﻿namespace JobPortal.Services.Job
{
	using JobPortal.Core.Data.Models;
	using JobPortal.ViewModels.Job;
	public interface IJobService
	{
		Task<List<JobOffersViewModel>> AllJobsAsync();
		Task<JobOffer> FindJobAsync(int jobId);
		Task<JobDetailsViewModel> BuildDetailsViewModel(JobOffer jobOffer, string userId);
		Task<bool> AlreadyAppliedForAJobAsync(int jobId, int applicationId);
		Task<List<AllApplicationsViewModel>> GetAllApplicationsAsync(string userId);
		Task AddJobApplicationToJobOfferAsync(int jobId, int applicationId);
		Task<List<AllCompaniesViewModel>> GetAllCompaniesAsync();
		Task<List<JobOffersViewModel>> GetCompanyOffers(int id);
	}
}
