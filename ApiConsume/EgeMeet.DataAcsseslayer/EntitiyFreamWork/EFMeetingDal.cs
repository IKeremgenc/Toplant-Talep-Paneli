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
    public class EFMeetingDal : GenericRepositories<Meeting>, IMeetingDal
    {
        public EFMeetingDal(Context context) : base(context)
        {
           
        }

        public void MeetingStatuseChange(int id)
        {
            var contex = new Context();
            var values = contex.Meetings.Find(id);
            values.Statues = true;
            contex.SaveChanges();
        }
    }
}
