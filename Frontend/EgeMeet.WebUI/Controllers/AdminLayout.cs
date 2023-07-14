using Microsoft.AspNetCore.Mvc;

namespace EgeMeet.WebUI.Controllers
{
    public class AdminLayout : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
        public PartialViewResult _HeaderLayout()
        {
            return PartialView();
        }
        public PartialViewResult _NavBarLayout()
        {
            return PartialView();
        }
        public PartialViewResult _SideBarLayout()
        {
            return PartialView();

        }
        public PartialViewResult _ScriptLayout()
        {
            return PartialView();

        }
    }
}
