using Microsoft.AspNetCore.Mvc;

namespace Margot_System.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
