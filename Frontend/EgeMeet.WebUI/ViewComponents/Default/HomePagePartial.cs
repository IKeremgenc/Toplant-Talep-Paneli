using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.WebUI.ViewComponents.Default
{
    public class HomePagePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
