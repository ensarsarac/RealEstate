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
    public class EfPropertyRepo : GenericRepository<Property>, IPropertyDal
    {
        public Property GetByIdWithInclude(int id)
        {
            Context c = new Context();
            return c.Properties.Include(x => x.PropertyStatus).Include(y => y.PropertyType).Include(z => z.AppUser).FirstOrDefault(x => x.ID == id);
        }

        public List<Property> GetListWithInclude()
        {
            Context c = new Context();
            var value = c.Properties.Include(x => x.PropertyStatus).Include(y => y.PropertyType).Include(x => x.AppUser).ToList();
            return value;
        }
    }
}
