using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.Areas.Admin.ViewComponents.Dashboard
{
    public class DashboardProperty : ViewComponent
    {
        PropertyManager pm = new PropertyManager(new EfPropertyRepo());

        public IViewComponentResult Invoke()
        {
            var values = pm.TGetListWithInclude();
            return View(values);
        }
    }
}
