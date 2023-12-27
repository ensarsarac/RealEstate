using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.Areas.Admin.ViewComponents
{
    public class DashboardUser : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var values = c.Users.ToList();
            return View(values);
        }
    }
}
