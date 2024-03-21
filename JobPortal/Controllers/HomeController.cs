using Microsoft.AspNetCore.Mvc;

namespace Job_Portal.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			if (User.Identity.IsAuthenticated && User?.Identity != null && User.IsInRole("Company"))
			{
				return RedirectToAction("All", "Company");
			}
			return View();
		}
	}
}
