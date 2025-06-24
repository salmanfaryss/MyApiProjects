using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebUI.Models.UserSetting;

namespace WebUI.Controllers
{
    public class SettingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            SettingViewModel settingViewModel = new SettingViewModel();
            settingViewModel.Name = user.Name;
            settingViewModel.Surname = user.Surname;
            settingViewModel.UserName = user.UserName;
            settingViewModel.Email = user.Email;
            return View(settingViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(SettingViewModel settingViewModel)
        {
            if(settingViewModel.Password == settingViewModel.ConfirmPassword)
            {
                var user =await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = settingViewModel.Name;
                user.Surname = settingViewModel.Surname;
                user.UserName = settingViewModel.UserName;
                user.Email = settingViewModel.Email;
                user.PasswordHash =_userManager.PasswordHasher.HashPassword(user,settingViewModel.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index","Login");

            }
            return View();
        }
    }
}
