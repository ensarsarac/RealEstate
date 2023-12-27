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
    public class PropertyStatusManager : PropertyStatusService
    {
        IPropertyStatusDal _propertyStatusDal;

        public PropertyStatusManager(IPropertyStatusDal propertyStatusDal)
        {
            _propertyStatusDal = propertyStatusDal;
        }

        public void TAdd(PropertyStatus t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(PropertyStatus t)
        {
            throw new NotImplementedException();
        }

        public PropertyStatus TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PropertyStatus> TGetList()
        {
            return _propertyStatusDal.GetList();
        }

        public void TUpdate(PropertyStatus t)
        {
            throw new NotImplementedException();
        }
    }
}
