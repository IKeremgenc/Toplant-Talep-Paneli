using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
