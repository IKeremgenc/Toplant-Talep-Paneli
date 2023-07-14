using EgeMeet.Bussines.Abstrack;
using EgeMeet.EntityLayer.Concrete;
using EgeMeet.WebUI.Models.HowToUs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.ApiConsuem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HowToUsController : ControllerBase
    {
        private readonly IHowToUsService _howToUsService;

        public HowToUsController(IHowToUsService howToUsService)
        {
            _howToUsService = howToUsService;
        }

        [HttpGet]
        public IActionResult HowToUsList()
        {
            var values = _howToUsService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddHowToUsPage(HowToUs howToUs)
        {
            _howToUsService.TInsert(howToUs);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteHowToUsPage(int id)
        {
            var values = _howToUsService.TGetByID(id);
            _howToUsService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateHowToUs(HowToUs howToUs)
        {
            _howToUsService.TUpdate(howToUs);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetHowToUs(int id)
        {
            var values = _howToUsService.TGetByID(id);
            return Ok(values);
        }
    }
}
