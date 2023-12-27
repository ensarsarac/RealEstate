using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageRepo : GenericRepository<Message>, IMessageDal
    {
        Context c = new Context();

        public Message GetMessageWithInclude(int id)
        {
            return c.Messages.Include(x => x.ReceiverUser).Include(x => x.SenderUser).FirstOrDefault(x => x.ID == id);
        }

        public List<Message> Inbox(int id)
        {
            var value = c.Messages.Include(x => x.SenderUser).Where(x => x.ReceiverUserId == id).ToList();
            return value;
        }

        public List<Message> Sendbox(int id)
        {
            var value = c.Messages.Include(x => x.ReceiverUser).Where(x => x.SenderUserId == id).ToList();
            return value;
        }
    }
}
