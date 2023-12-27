using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.ViewComponents.Default
{
    public class DefaultProperty : ViewComponent
    {
        PropertyManager pm = new PropertyManager(new EfPropertyRepo());
        public IViewComponentResult Invoke()
        {
            return View(pm.TGetListWithInclude().Take(3).ToList());
        }
    }
}
