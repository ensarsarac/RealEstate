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
    public class About1Manager : About1Service
    {
        IAbout1Dal _about1Dal;

        public About1Manager(IAbout1Dal about1Dal)
        {
            _about1Dal = about1Dal;
        }

        public void TAdd(About1 t)
        {
            _about1Dal.Insert(t);
        }

        public void TDelete(About1 t)
        {
            _about1Dal.Delete(t);
        }

        public About1 TGetById(int id)
        {
            return _about1Dal.GetById(id);
        }

        public List<About1> TGetList()
        {
            return _about1Dal.GetList();
        }

        public void TUpdate(About1 t)
        {
            _about1Dal.Update(t);
        }
    }
}
