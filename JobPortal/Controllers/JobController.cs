using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
