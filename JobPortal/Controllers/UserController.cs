using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
