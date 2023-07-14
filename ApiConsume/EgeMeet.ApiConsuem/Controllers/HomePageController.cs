using EgeMeet.Bussines.Abstrack;
using EgeMeet.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.ApiConsuem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        private readonly IHomePageService _homePageService;

        public HomePageController(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }

        [HttpGet]
        public IActionResult HomeList()
        {
            var values = _homePageService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddHomePage(HomePage homePage)
        {
            _homePageService.TInsert(homePage);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteHomePage(int id)
        {
            var values = _homePageService.TGetByID(id);
            _homePageService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateHome(HomePage homePage)
        {
            _homePageService.TUpdate(homePage);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetHome(int id)
        {
            var values = _homePageService.TGetByID(id);
            return Ok(values);
        }
    }
}
