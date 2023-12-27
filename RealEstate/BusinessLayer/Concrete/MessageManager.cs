using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : MessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public Message TGetMessageWithInclude(int id)
        {
            return _messageDal.GetMessageWithInclude(id);
        }

        public List<Message> TInbox(int id)
        {
            return _messageDal.Inbox(id);
        }

        public List<Message> TSendbox(int id)
        {
            return _messageDal.Sendbox(id);
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
