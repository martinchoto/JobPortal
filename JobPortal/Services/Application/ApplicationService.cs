using Job_Portal.Data;
using JobPortal.Core.Constants;
using JobPortal.Core.Data.Models;
using JobPortal.ViewModels.Application;
using Microsoft.EntityFrameworkCore;

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
	}
}
