using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.WebUI.ViewComponents.Default
{
    public class _NavBarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
