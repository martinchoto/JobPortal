using JobPortal.Core.Constants;
using JobPortal.Core.Data;
using JobPortal.Core.Data.Models;
using JobPortal.ViewModels.Application;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace JobPortal.Services.Application
{
    public class ApplicationService : IApplicationService
    {
        private readonly JobPortalDbContext _context;
        public ApplicationService(JobPortalDbContext context)
        {
            _context = context;
        }
        public async Task AddApplicationAsync(AddJobApplicationViewModel viewModel, string applicantId)
        {
            JobApplication application = new JobApplication()
            {
                FullName = viewModel.FullName,
                Email = viewModel.Email,
                Description = viewModel.Description,
                Reason = viewModel.Reasons,
                CreatedOn = DateTime.Now,
                UserId = applicantId,
                Name = viewModel.ApplicationName
            };

            await _context.Applications.AddAsync(application);
            await _context.SaveChangesAsync();
        }

        public async Task<AddJobApplicationViewModel> BuildViewModel(JobApplication jobApplication)
        {
            return new AddJobApplicationViewModel()
            {
                ApplicationName = jobApplication.Name,
                FullName = jobApplication.FullName,
                Email = jobApplication.Email,
                Description = jobApplication.Description,
                Reasons = jobApplication.Reason
            };
        }

        public async Task EditJobApplicationAsync(AddJobApplicationViewModel model, int id)
        {
            var toBeEdited = await GetApplication(id);

            toBeEdited.CreatedOn = DateTime.Now;
            toBeEdited.Name = model.ApplicationName;
            toBeEdited.FullName = model.FullName;
            toBeEdited.Description = model.Description;
            toBeEdited.Reason = model.Reasons;
            toBeEdited.Email = model.Email;
            await _context.SaveChangesAsync();
        }

        public async Task<JobApplication> GetApplication(int id)
        {
            return await _context.Applications.FindAsync(id);
        }

        public async Task<List<MyJobApplicationViewModel>> GetApplicationsAsync(string applicantId)
        {
            var myViewModel = await _context.Applications
                .Where(x => x.UserId == applicantId)
                .Select(x => new MyJobApplicationViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreatedOn = x.CreatedOn.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture)
                })
                .ToListAsync();
            return myViewModel;
        }
        public async Task<DeleteApplicationViewModel> BuildDeleteModelAsync(JobApplication application)
        {
            DeleteApplicationViewModel viewModel = new DeleteApplicationViewModel()
            {
                Id = application.Id,
                Name = application.Name,
                UpdatedOn = application.CreatedOn.ToString(DataConstants.DATE_FORMAT, CultureInfo.InvariantCulture)
            };

            return viewModel;
        }

        public async Task DeleteApplicationAsync(JobApplication application)
        {
            if (application.JobOfferApplications.Any())
            {
                application.JobOfferApplications.Clear();
            }
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();

        }

		public async Task<DetailsApplicationViewModel> BuildDetailsViewModelAsync(JobApplication jobApp)
		{
            DetailsApplicationViewModel viewModel = new DetailsApplicationViewModel()
            {
                Description = jobApp.Description,
                Email = jobApp.Email,
                FullName = jobApp.FullName,
                Name = jobApp.Name,
                Reasons = jobApp.Reason
            };
            return viewModel;
		}

	}
}
