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
    public class DashboardMessagee : ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageRepo());
        private readonly UserManager<AppUser> _userManager;
        public DashboardMessagee(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var messages = mm.TInbox(user.Id).OrderByDescending(x => x.Date).Take(3).ToList();
            return View(messages);
        }
    }
}
