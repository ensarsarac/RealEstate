using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.ViewComponents.Default
{
    public class FooterAddress: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ContactManager cm = new ContactManager(new EfContactRepo());
            return View(cm.TGetById(1));
        }
    }
}
