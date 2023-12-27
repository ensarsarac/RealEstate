using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.ViewComponents.Writer
{
    public class WriterNavbarNotification : ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepo());
        public IViewComponentResult Invoke()
        {
            var values = nm.TGetList().Where(x => x.Status == true).ToList();
            return View(values);
        }
    }
}
