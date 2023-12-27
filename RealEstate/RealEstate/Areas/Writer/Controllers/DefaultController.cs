using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealEstate.Areas.Writer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize(Roles ="Admin,Writer,Moderator")]
    public class DefaultController : Controller
    {
        PropertyManager pm = new PropertyManager(new EfPropertyRepo());
        Context c = new Context();
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public DefaultController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {

            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = pm.TGetListWithInclude().Where(x => x.AppUserId == user.Id).Count();
            ViewBag.v2 = c.Messages.Where(x => x.ReceiverUserId == user.Id).Count();
            ViewBag.v3 = c.Favorites.Where(x => x.AppUserId == user.Id).Count();
            return View();
        }

        
        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            var user = c.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            var viewmodel = new ProfileViewModel() {
                Name = user.Name,
                Surname = user.Surname,
                PhoneNumber = user.PhoneNumber
            };
            return View(viewmodel);
        }

        [HttpPost]
        public async Task<IActionResult> MyProfile(ProfileViewModel p)
        {
            Context c = new Context();
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
            user.PhoneNumber = p.PhoneNumber;
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
