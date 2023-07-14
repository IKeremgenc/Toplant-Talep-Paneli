using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.WebUI.ViewComponents.Default
{
    public class _HeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
