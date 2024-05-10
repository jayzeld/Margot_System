using Microsoft.AspNetCore.Mvc;

namespace Margot_System.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
