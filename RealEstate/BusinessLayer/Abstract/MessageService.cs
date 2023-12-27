using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface MessageService: GenericService<Message>
    {
        List<Message> TInbox(int id);
        List<Message> TSendbox(int id);

        Message TGetMessageWithInclude(int id);
    }
}
