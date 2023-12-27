using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.ViewComponents.Default
{
    public class DefaultContactMessage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new ContactMessage());
        }
    }
}
