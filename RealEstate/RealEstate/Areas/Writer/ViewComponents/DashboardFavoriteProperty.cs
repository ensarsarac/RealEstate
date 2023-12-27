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
    public class DashboardFavoriteProperty : ViewComponent
    {
        FavoriteManager fm = new FavoriteManager(new EfFavoriteRepo());
        private readonly UserManager<AppUser> _userManager;

        public DashboardFavoriteProperty(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = fm.TGetListWithInclude(user.Id).Take(5).ToList();

            return View(values);
        }
    }
}
