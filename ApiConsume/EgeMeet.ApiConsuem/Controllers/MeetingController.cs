using EgeMeet.Bussines.Abstrack;
using EgeMeet.BussinesLayer.Abstrack;
using EgeMeet.DataAcsseslayer.Abstract;
using EgeMeet.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.ApiConsuem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingService _meetingService;

      
        public MeetingController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }

        [HttpGet]
        public IActionResult MeetingList()
        {
            var values = _meetingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult MeetingHomePage(Meeting meeting)
        {
            _meetingService.TInsert(meeting);
            return Ok();
        }
        [HttpDelete]
        public IActionResult MeetingDelete(int id)
        {
            var values = _meetingService.TGetByID(id);
            _meetingService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMeeting(Meeting meeting)
        {
            _meetingService.TUpdate(meeting);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetMeetintg(int id)
        {
            var values = _meetingService.TGetByID(id);
            return Ok(values);
        }
        [HttpGet("Meetingapproved{id}")]
        public IActionResult Meetingapproved(int id )
        {
           _meetingService.TMeetingStatuseChange(id);
            return Ok();
        }
    }
}
