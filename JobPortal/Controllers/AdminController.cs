using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
