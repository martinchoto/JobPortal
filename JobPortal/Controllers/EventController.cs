using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
	public class EventController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
