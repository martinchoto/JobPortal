using JobPortal.Core.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace JobPortal.Controllers
{
	public class HomeController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			if (User.Identity.IsAuthenticated && User?.Identity != null && User.IsInRole("Company"))
			{
				return RedirectToAction("All", "Company");
			}
			if (User.Identity.IsAuthenticated && User?.Identity != null && User.IsInRole("Applicant"))
			{
				return RedirectToAction("All", "Job");
			}
			return View();
		}
		public async Task<IActionResult> Error(int statusCode)
		{
			switch (statusCode)
			{
				case 400: return View("Error400");
				case 401: return View("Error401");
				case 404: return View("Error404");
			}

			return View("Error");
		}
	}
}
