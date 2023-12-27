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
    [Authorize(Roles = "Admin,Writer,Moderator")]
    public class PropertyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        PropertyManager pm = new PropertyManager(new EfPropertyRepo());
        FavoriteManager fm = new FavoriteManager(new EfFavoriteRepo());

        public PropertyController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyProperty()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = pm.TGetListWithInclude().Where(x => x.AppUserId == user.Id).ToList();
            return View(values);
        }

        public IActionResult RemoveProperty(int id)
        {            
            var value = pm.TGetById(id);
            pm.TDelete(value);
            return RedirectToAction("MyProperty");
        }

        [HttpGet]
        public IActionResult AddProperty()
        {
            PropertyTypeManager ptm = new PropertyTypeManager(new EfPropertyTypeRepo());
            PropertyStatusManager psm = new PropertyStatusManager(new EfPropertyStatusRepo());
            ViewBag.selectList = new SelectList(ptm.TGetList(), "ID", "Name");
            ViewBag.selectList2 = new SelectList(psm.TGetList(), "ID", "Name");
            return View(new PropertyViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddProperty(PropertyViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            PropertyManager pm = new PropertyManager(new EfPropertyRepo());
            Property model = new Property();

            if (p.ImageProperty != null)
            {
                var extension = Path.GetExtension(p.ImageProperty.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PropertyImage/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageProperty.CopyTo(stream);
                model.Image = newImageName;
            }

            model.Date = DateTime.Now;
            model.Title = p.Title;
            model.Description = p.Description;
            model.Price = p.Price;
            model.City = p.City;
            model.Street = p.Street;
            model.Bet = p.Bet;
            model.Bath = p.Bath;
            model.Sqft = p.Sqft;
            model.PropertyTypeId = p.PropertyTypeId;
            model.PropertyStatusId = p.PropertyStatusId;
            model.Status = true;
            model.AppUserId = user.Id;


            pm.TAdd(model);
            return RedirectToAction("MyProperty","Property");
        }



        public async Task<IActionResult> MyFavoriteProperty()
        {
            Context c = new Context();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = fm.TGetListWithInclude(user.Id);
            return View(values);
        }

        public IActionResult RemoveMyFavoriteProperty(int id)
        {
            Context c = new Context();
            var value = fm.TGetById(id);
            fm.TDelete(value);
            
            return RedirectToAction("MyFavoriteProperty");
        }


        [HttpGet]
        public IActionResult UpdateProperty(int id)
        {
            PropertyTypeManager ptm = new PropertyTypeManager(new EfPropertyTypeRepo());
            PropertyStatusManager psm = new PropertyStatusManager(new EfPropertyStatusRepo());
            ViewBag.selectList = new SelectList(ptm.TGetList(), "ID", "Name");
            ViewBag.selectList2 = new SelectList(psm.TGetList(), "ID", "Name");
            var value = pm.TGetById(id);
            PropertyViewModel model = new PropertyViewModel();
            model.ID = id;
            model.Title = value.Title;
            model.Description = value.Description;
            model.Price = value.Price;
            model.City = value.City;
            model.Street = value.Street;
            model.Bet = value.Bet;
            model.Bath = value.Bath;
            model.Sqft = value.Sqft;
            model.PropertyTypeId = value.PropertyTypeId;
            model.PropertyStatusId = value.PropertyStatusId;

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateProperty(PropertyViewModel p)
        {
            //PropertyTypeManager ptm = new PropertyTypeManager(new EfPropertyTypeRepo());
            //PropertyStatusManager psm = new PropertyStatusManager(new EfPropertyStatusRepo());
            //ViewBag.selectList = new SelectList(ptm.TGetList(), "ID", "Name");
            //ViewBag.selectList2 = new SelectList(psm.TGetList(), "ID", "Name");

            var value = pm.TGetById(p.ID);
            if (p.ImageProperty != null)
            {
                var extension = Path.GetExtension(p.ImageProperty.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PropertyImage/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageProperty.CopyTo(stream);
                value.Image = newImageName;
            }
            value.Title = p.Title;
            value.Description = p.Description;
            value.Price = p.Price;
            value.City = p.City;
            value.Street = p.Street;
            value.Bet = p.Bet;
            value.Bath = p.Bath;
            value.Sqft = p.Sqft;
            value.PropertyTypeId = p.PropertyTypeId;
            value.PropertyStatusId = p.PropertyStatusId;
            pm.TUpdate(value);
            return RedirectToAction("MyProperty");
        }
    }
}
