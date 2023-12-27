using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealEstateProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers
{
    [Area("Writer")]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel p)
        {
            var user = await _userManager.FindByEmailAsync(p.UserName);
            var value = await _signInManager.PasswordSignInAsync(user.UserName, p.Password, true, true);
            if (value.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı!");
                return View(p);
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterFormViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormViewModel p)
        {
            AppUser a = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                UserName = p.UserName,
                Email = p.Email,
                PhoneNumber = p.Phone,
                Image = "default-user.png",
            };
            a.PasswordHash = _userManager.PasswordHasher.HashPassword(a, p.Password);
            await _userManager.CreateAsync(a, p.Password);
            return RedirectToAction("Index", "Login");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Default", new { area=""});
        }


    }
}
