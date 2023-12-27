using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.Areas.Admin.ViewComponents
{
    public class DashboardStatistic : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardStatistic(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            Context c = new Context();
            ViewBag.v1 = c.Messages.Where(x => x.ReceiverUserId == user.Id).Count();
            ViewBag.v2 = c.Messages.Where(x => x.SenderUserId == user.Id).Count();
            ViewBag.v3 = c.Properties.Count();
            ViewBag.v4 = c.Users.Count();
            return View();
        }
    }
}
