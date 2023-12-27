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
    public class PropertyTypeManager : PropertyTypeService
    {
        IPropertyTypeDal _propertyTypeDal;

        public PropertyTypeManager(IPropertyTypeDal propertyTypeDal)
        {
            _propertyTypeDal = propertyTypeDal;
        }

        public void TAdd(PropertyType t)
        {
            _propertyTypeDal.Insert(t);
        }

        public void TDelete(PropertyType t)
        {
            _propertyTypeDal.Delete(t);
        }

        public PropertyType TGetById(int id)
        {
            return _propertyTypeDal.GetById(id);
        }

        public List<PropertyType> TGetList()
        {
            return _propertyTypeDal.GetList();
        }

        public void TUpdate(PropertyType t)
        {
            _propertyTypeDal.Update(t);
        }
    }
}
