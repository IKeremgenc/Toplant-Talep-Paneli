using EgeMeet.Bussines.Abstrack;
using EgeMeet.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.BussinesLayer.Abstrack
{
    public interface IMeetingService : IGnericService<Meeting>
    {
        void TMeetingStatuseChange(int id);
    }
}
