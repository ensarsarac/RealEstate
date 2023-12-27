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
    public class EfFavoriteRepo : GenericRepository<Favorite>, IFavoriteDal
    {
        public List<Favorite> GetListWithInclude(int id)
        {
            Context c = new Context();
            return c.Favorites.Include(x => x.AppUser).Include(y => y.Property).ThenInclude(z => z.AppUser).Where(d => d.AppUserId == id).ToList();
        }
    }
}
