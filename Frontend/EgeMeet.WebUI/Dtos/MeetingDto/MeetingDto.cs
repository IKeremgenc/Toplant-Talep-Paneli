using System;

namespace EgeMeet.WebUI.Dtos.MeetingDto
{
    public class MeetingDto
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
