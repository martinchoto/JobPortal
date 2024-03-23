using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
	[Authorize(Roles = "Applicant")]
	public class ApplicationController : Controller
	{
		public async Task<IActionResult> Create()
		{
			return View();
		}
		public IActionResult Apply(int id)
		{
			return View();
		}
	}
}
