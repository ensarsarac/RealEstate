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
    public class FavoriteManager : FavoriteService
    {
        IFavoriteDal _favoriteDal;

        public FavoriteManager(IFavoriteDal favoriteDal)
        {
            _favoriteDal = favoriteDal;
        }

        public void TAdd(Favorite t)
        {
            _favoriteDal.Insert(t);
        }

        public void TDelete(Favorite t)
        {
            _favoriteDal.Delete(t);
        }

        public Favorite TGetById(int id)
        {
            return _favoriteDal.GetById(id);
        }

        public List<Favorite> TGetList()
        {
            return _favoriteDal.GetList();
        }

        public List<Favorite> TGetListWithInclude(int id)
        {
            return _favoriteDal.GetListWithInclude(id);
        }

        public void TUpdate(Favorite t)
        {
            _favoriteDal.Update(t);
        }
    }
}
