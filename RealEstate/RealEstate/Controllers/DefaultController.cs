using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        ContactManager cm = new ContactManager(new EfContactRepo());
        PropertyManager pm = new PropertyManager(new EfPropertyRepo());
        ContactMessageManager repo = new ContactMessageManager(new EfContactMessageRepo());


        public DefaultController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View(cm.TGetById(1));
        }

        [HttpPost]
        public IActionResult AddContactMessage(ContactMessage p)
        {
            if (ModelState.IsValid)
            {
                repo.TAdd(p);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Contact");
        }

        [HttpGet]
        public IActionResult PropertyList(string search, int? id)
        {

            if (!String.IsNullOrEmpty(search))
            {
                return View(pm.TGetListWithInclude().Where(x => x.Title.ToLower().Contains(search)).ToList());
            }
            else if (id != null)
            {
                if (id == 0)
                {
                    return View(pm.TGetListWithInclude());
                }
                return View(pm.TGetListWithInclude().Where(x => x.PropertyStatusId == id).ToList());
            }

            else
            {
                return View(pm.TGetListWithInclude());
            }
        }

        public IActionResult PropertyDetails(int id)
        {

            var value = pm.TGetByIdWithInclude(id);
            return View(value);
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {

            return PartialView();
        }


        public async Task<IActionResult> AddFavorite(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            Favorite m = new Favorite()
            {
                AppUserId = user.Id,
                PropertyID = id,
            };
            FavoriteManager fm = new FavoriteManager(new EfFavoriteRepo());
            fm.TAdd(m);
            return RedirectToAction("PropertyList");
        }



    }
}
