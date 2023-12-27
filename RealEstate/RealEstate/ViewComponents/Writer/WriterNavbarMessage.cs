using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.ViewComponents.Writer
{
    public class WriterNavbarMessage : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        MessageManager mm = new MessageManager(new EfMessageRepo());

        public WriterNavbarMessage(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = mm.TInbox(user.Id).OrderByDescending(x => x.Date).Take(3).ToList();
            return View(values);
        }
    }
}
