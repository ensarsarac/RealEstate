using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.ViewComponents.Default
{
    public class DefaultPropertyType : ViewComponent
    {
        PropertyTypeManager repo = new PropertyTypeManager(new EfPropertyTypeRepo());
        public IViewComponentResult Invoke()
        {
            return View(repo.TGetList());
        }
    }
}
