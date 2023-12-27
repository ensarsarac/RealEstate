using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.ViewComponents.Default
{
    public class DefaultAbout2: ViewComponent
    {
        About2Manager repo = new About2Manager(new EfAbout2Repo());
        public IViewComponentResult Invoke()
        {
            return View(repo.TGetList().FirstOrDefault());
        }
    }
}
