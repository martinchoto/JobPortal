using Microsoft.AspNetCore.Mvc;

namespace Job_Portal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToPage("/Home/Index");
        }
    }
}
