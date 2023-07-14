using EgeMeet.DataAcsseslayer.Abstract;
using EgeMeet.DataAcsseslayer.Concrete;
using EgeMeet.DataAcsseslayer.Repositories;
using EgeMeet.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.DataAcsseslayer.EntitiyFreamWork
{
    public class EFHomePageDal : GenericRepositories<HomePage>, IHomePageDal
    {
        public EFHomePageDal(Context context) : base(context)
        {
        }
    }
}
