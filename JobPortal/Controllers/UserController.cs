using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
	[AllowAnonymous]
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
