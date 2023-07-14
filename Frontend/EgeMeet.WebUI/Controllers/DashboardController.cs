using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
