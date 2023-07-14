using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.EntityLayer.Concrete
{
    public class MeetingRequest
    {
        public int MeetingRequestid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingDescription { get; set; }
        public string Description { get; set; }
    }
}
