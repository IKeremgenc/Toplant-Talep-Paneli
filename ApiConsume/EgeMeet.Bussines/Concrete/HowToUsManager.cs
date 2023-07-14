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
    public class HowToUsManager : IHowToUsService
    {
        private readonly IHowToUsDal howToUsDal;

        public HowToUsManager(IHowToUsDal howToUsDal)
        {
            this.howToUsDal = howToUsDal;
        }

        public void TDelete(HowToUs t)
        {
            howToUsDal.Delete(t);

        }

        public HowToUs TGetByID(int id)
        {
            return howToUsDal.GetByID(id);
        }

        public List<HowToUs> TGetList()
        {
            return howToUsDal.GetList();
        }

        public void TInsert(HowToUs t)
        {
            howToUsDal.Insert(t);
        }

        public void TUpdate(HowToUs t)
        {
            howToUsDal.Update(t);
        }
    }
}
