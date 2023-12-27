using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.ViewComponents.Default
{
    public class DefaultFeature: ViewComponent
    {
        FeatureManager fm = new FeatureManager(new EfFeatureRepo());
        public IViewComponentResult Invoke()
        {
            return View(fm.TGetList().FirstOrDefault());
        }
    }
}
