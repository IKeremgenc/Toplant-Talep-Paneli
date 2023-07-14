using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.EntityLayer.Concrete
{
    public class Meeting
    {
        public int Meetingid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingDescription { get; set; }
        public string Description { get; set; }
        public bool Statues { get; set; }
    }
}
