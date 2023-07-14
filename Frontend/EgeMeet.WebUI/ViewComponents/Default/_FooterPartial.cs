using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.WebUI.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
