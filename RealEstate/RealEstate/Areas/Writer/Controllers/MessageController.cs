using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize(Roles = "Admin,Writer,Moderator")]
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        MessageManager mm = new MessageManager(new EfMessageRepo());

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Inbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = mm.TInbox(user.Id);
            return View(values);
        }

        public IActionResult RemoveMessage(int id)
        {
            var value = mm.TGetById(id);
            mm.TDelete(value);
            return RedirectToAction("Inbox");
        }

        public async Task<IActionResult> AddMessage(string Mail, string Subject, string MessageContent)
        {
            var senderuser = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiveruser = await _userManager.FindByEmailAsync(Mail);
            Message m = new Message() {

                ReceiverUserId = receiveruser.Id,
                SenderUserId = senderuser.Id,
                Subject = Subject,
                MessageContent = MessageContent,
            };
            mm.TAdd(m);
            return RedirectToAction("Sendbox");
        }

        public async Task<IActionResult> Sendbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = mm.TSendbox(user.Id);
            return View(values);
        }


        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetMessageWithInclude(id);

            return View(value);
        }


    }
}
