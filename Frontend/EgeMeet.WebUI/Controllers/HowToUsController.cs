using EgeMeet.WebUI.Models.HomePage;
using EgeMeet.WebUI.Models.HowToUs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.WebUI.Controllers
{
    public class HowToUsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HowToUsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("  http://localhost:22204/api/HowToUs");
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsondata = await responsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<HowToUsViewModel>>(jsondata);
                return View(values);
            }
            return View();


        }
        [HttpGet]
        public IActionResult AddHowToUs()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddHowToUs(AddHowToUsViewModel addHowToUsViewModel)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(addHowToUsViewModel);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("http://localhost:22204/api/HowToUs", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> DeleteHowToUs(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:22204/api/HowToUs{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateHowToUs(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"  http://localhost:22204/api/HowToUs{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<HowToUsUpdateViewModel>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateHowToUs(HowToUsUpdateViewModel pageViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jhsondata = JsonConvert.SerializeObject(pageViewModel);
            StringContent stringContent = new StringContent(jhsondata, Encoding.UTF8, "appclication/json");
            var responseMessage = await client.PutAsync($" http://localhost:22204/api/HowToUs", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
