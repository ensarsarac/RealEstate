using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Areas.Writer.ViewComponents
{
    public class DashboardMyProperty : ViewComponent
    {
        PropertyManager pm = new PropertyManager(new EfPropertyRepo());
        private readonly UserManager<AppUser> _userManager;

        public DashboardMyProperty(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = pm.TGetList().Take(3).ToList();
            return View(values);
        }
    }
}
