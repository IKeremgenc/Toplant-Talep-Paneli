using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.WebUI.ViewComponents.Default
{
    public class HowToUs:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
