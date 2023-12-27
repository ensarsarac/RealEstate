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
    public class EmployeeManager : EmployeeService
    {
        IEmployeeDal _employeDal;

        public EmployeeManager(IEmployeeDal employeDal)
        {
            _employeDal = employeDal;
        }

        public void TAdd(Employee t)
        {
            _employeDal.Insert(t);
        }

        public void TDelete(Employee t)
        {
            _employeDal.Delete(t);
        }

        public Employee TGetById(int id)
        {
            return _employeDal.GetById(id);
        }

        public List<Employee> TGetList()
        {
            return _employeDal.GetList();
        }

        public void TUpdate(Employee t)
        {
            _employeDal.Update(t);
        }
    }
}
