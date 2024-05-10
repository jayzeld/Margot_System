using Microsoft.AspNetCore.Mvc;
using Margot_System.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Margot_System.Controllers
{
    public class LoginController(SignInManager<LoginModel> signInManager, MargotDbContext context) : Controller
    {
        private readonly SignInManager<LoginModel> _signInManager = signInManager;
        private readonly MargotDbContext _context = context;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.LoginTbs.FirstOrDefault(u => u.UserName == model.UserName);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home"); // Redirect to home page upon successful login
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            if (_signInManager.IsSignedIn(User))
            {
                _signInManager.SignOutAsync().GetAwaiter().GetResult();
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
