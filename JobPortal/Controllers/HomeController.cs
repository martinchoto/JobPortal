using JobPortal.Core.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
	}
}
