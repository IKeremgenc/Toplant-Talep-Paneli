using EgeMeet.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.DataAcsseslayer.Abstract
{
    public interface IMeetingDal:IGenericDal<Meeting>
    {
        void MeetingStatuseChange(int id);
    }
}
