using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.ViewComponents.Default
{
    public class DefaultAbout1: ViewComponent
    {
        About1Manager repo = new About1Manager(new EfAbout1Repo());
        public IViewComponentResult Invoke()
        {

            return View(repo.TGetList());
        }
    }
}
