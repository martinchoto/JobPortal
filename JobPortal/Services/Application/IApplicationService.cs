using JobPortal.ViewModels.Application;

namespace JobPortal.Services.Application
{
	public interface IApplicationService
	{
		Task AddApplicationAsync(AddJobApplicationViewModel viewModel, string applicantId);
	}
}
