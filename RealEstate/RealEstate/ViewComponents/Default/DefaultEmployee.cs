using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateProje.ViewComponents.Default
{
    public class DefaultEmployee: ViewComponent
    {
        EmployeeManager em = new EmployeeManager(new EfEmployeeRepo());
        public IViewComponentResult Invoke()
        {
            return View(em.TGetList());
        }
    }
}
