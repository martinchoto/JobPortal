using JobPortal.Services.Application;
using JobPortal.ViewModels.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JobPortal.Controllers
{
	[Authorize(Roles = "Applicant")]
	public class ApplicationController : Controller
	{
		private readonly IApplicationService _applicationService;
		public ApplicationController(IApplicationService applicationService)
		{
			_applicationService = applicationService;
		}

		public async Task<IActionResult> Mine()
		{
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			AddJobApplicationViewModel viewModel = new AddJobApplicationViewModel();

			return View(viewModel);
		}
		[HttpPost]
		public async Task<IActionResult> Create(AddJobApplicationViewModel viewModel)
		{
			if (!ModelState.IsValid)
			{
				return View(viewModel);
			}
			await _applicationService.AddApplicationAsync(viewModel, GetUserId());
			return RedirectToAction(nameof(Mine), "Application");
		}
		public IActionResult Apply(int id)
		{
			return View();
		}
		private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
	}
}
