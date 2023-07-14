using EgeMeet.WebUI.Dtos.MeetingDto;
using EgeMeet.WebUI.Models.HomePage;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.WebUI.Controllers
{
    public class HomePageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HomePageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("  http://localhost:22204/api/homepage");
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsondata = await responsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<MeetingDto>>(jsondata);
                return View(values);
            }
            return View();


        }
        [HttpGet]
        public async Task<IActionResult> UpdateHome(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"  http://localhost:22204/api/HomePage{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateHomePageViewModel>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateHome(UpdateHomePageViewModel pageViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jhsondata = JsonConvert.SerializeObject(pageViewModel);
            StringContent stringContent = new StringContent(jhsondata, Encoding.UTF8, "appclication/json");
            var responseMessage = await client.PutAsync($"  http://localhost:22204/api/HomePage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
