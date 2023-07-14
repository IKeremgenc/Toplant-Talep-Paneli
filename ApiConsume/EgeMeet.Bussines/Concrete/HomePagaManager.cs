using EgeMeet.Bussines.Abstrack;
using EgeMeet.DataAcsseslayer.Abstract;
using EgeMeet.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.Bussines.Concrete
{
    public class HomePagaManager : IHomePageService
    {
        private readonly IHomePageDal _homePageDal;

        public HomePagaManager(IHomePageDal homePageDal)
        {
            _homePageDal = homePageDal;
        }

        public void TDelete(HomePage t)
        {
            _homePageDal.Delete(t);
        }

        public HomePage TGetByID(int id)
        {
            return _homePageDal.GetByID(id);
        }

        public List<HomePage> TGetList()
        {
            return _homePageDal.GetList();
        }

        public void TInsert(HomePage t)
        {
            _homePageDal.Insert(t);
        }

        public void TUpdate(HomePage t)
        {
            _homePageDal.Update(t);
        }
    }
}
