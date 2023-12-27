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
    public class ContactMessageManager : ContactMessageService
    {
        IContactMessageDal _contactMessageDal;

        public ContactMessageManager(IContactMessageDal contactMessageDal)
        {
            _contactMessageDal = contactMessageDal;
        }

        public void TAdd(ContactMessage t)
        {
            _contactMessageDal.Insert(t);
        }

        public void TDelete(ContactMessage t)
        {
            throw new NotImplementedException();
        }

        public ContactMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
