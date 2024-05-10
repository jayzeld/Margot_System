using Microsoft.AspNetCore.Mvc;
using Margot_System.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace Margot_System.Controllers
{
    public class RegisterController(UserManager<LoginModel> userManager, MargotDbContext context) : Controller
    {
        private readonly UserManager<LoginModel> _userManager = userManager;
        private readonly MargotDbContext _context = context;

        [HttpPost]
        public IActionResult Index(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.Pass != model.Cpass)
                    {
                        ViewBag.ErrorMessage = "Password and confirm password do not match.";
                        return View(model);
                    }

                    var user = new LoginModel
                    {
                        UserName = model.Uname
                    };

                    var result = _userManager.CreateAsync(user, model.Pass).GetAwaiter().GetResult();

                    if (result.Succeeded)
                    {
                        var registerEntry = new RegisterModel
                        {
                            Fname = model.Fname,
                            Lname = model.Lname,
                            Mname = model.Mname,
                            Uname = model.Uname,
                        };

                        _context.RegisterTbs.Add(registerEntry);
                        _context.SaveChanges();

                        ViewBag.SuccessMessage = "User has been registered";
                    }
                    else
                    {
                        var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                        ViewBag.ErrorMessage = errors;
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = $"An error occurred while registering the user: {ex.Message}";
                }
            }

            return View(model);
        }
    }
}
