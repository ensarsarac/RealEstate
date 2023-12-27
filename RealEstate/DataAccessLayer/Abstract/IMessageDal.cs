using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal: IGenericDal<Message>
    {
        List<Message> Inbox(int id);
        List<Message> Sendbox(int id);

        Message GetMessageWithInclude(int id);
    }
}
