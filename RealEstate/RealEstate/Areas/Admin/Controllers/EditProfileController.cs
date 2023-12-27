using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EditProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        Context c = new Context();

        public EditProfileController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var viewmodel = new EditProfileViewModel() { 
                ID = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Phone = user.PhoneNumber
            };
            return View(viewmodel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(EditProfileViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)
            {
                var extension = Path.GetExtension(p.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserImage/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.Image.CopyTo(stream);
                user.Image = newImageName;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PhoneNumber = p.Phone;
            await _userManager.UpdateAsync(user);
            if (p.Password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
                await _userManager.UpdateAsync(user);
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Login", new { area = "" });
            }
            return RedirectToAction("Index", "Default");
        }



    }
}
