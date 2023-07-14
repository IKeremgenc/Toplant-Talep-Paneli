using EgeMeet.EntityLayer.Concrete;
using EgeMeet.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EgeMeet.WebUI.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public IActionResult Index()
		{	
			return View();
		}
		[HttpPost]
		public async Task< IActionResult >Index(CreatNewUserDto creatNewUser)
		{
			if(ModelState.IsValid)
			{

			}
			var appuser = new AppUser()
			{
				Name = creatNewUser.Name,
				Surname = creatNewUser.Surname,
				Email = creatNewUser.Mail,
				City = creatNewUser.City

			};
			var result=await _userManager.CreateAsync(appuser,creatNewUser.Password);
			if (result.Succeeded)
			{
				return RedirectToAction("Index","Login");	
			}
			return View();
		}
	}
}
