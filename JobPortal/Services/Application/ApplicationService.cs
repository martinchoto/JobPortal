using Job_Portal.Data;
using JobPortal.Core.Constants;
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

		public async Task<List<MyJobApplicationViewModel>> GetApplicationAsync(string applicantId)
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
	}
}
