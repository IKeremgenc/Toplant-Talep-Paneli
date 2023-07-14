using System.ComponentModel.DataAnnotations;

namespace EgeMeet.WebUI.Dtos.RegisterDto
{
	public class CreatNewUserDto
	{
		[Required(ErrorMessage ="Lütfen Boş Geçmeyiniz !")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen Boş Geçmeyiniz !")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Lütfen Boş Geçmeyiniz !")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Lütfen Boş Geçmeyiniz !")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen Boş Geçmeyiniz !")]
		public string City { get; set; }
	}
}
