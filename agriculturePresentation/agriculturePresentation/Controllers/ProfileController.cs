using agriculturePresentation.Models;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace agriculturePresentation.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Mail = value.Email;
            userEditViewModel.Phone = value.PhoneNumber;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task <IActionResult> Index(UserEditViewModel p)
        {
            if (p.Password == p.ConfirmPassword)
            {
                var values = await _userManager.FindByNameAsync(User.Identity.Name);
                values.PhoneNumber = p.Phone;
                values.Email = p.Mail;
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, p.Password);

                var result = await _userManager.UpdateAsync(values);
                if (result.Succeeded)
                {   
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
