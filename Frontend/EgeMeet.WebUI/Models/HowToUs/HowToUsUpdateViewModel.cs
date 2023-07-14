using System.ComponentModel.DataAnnotations;

namespace EgeMeet.WebUI.Models.HowToUs
{
    public class HowToUsUpdateViewModel
    {
        public int HowToUsid { get; set; }
        [Required(ErrorMessage ="Lütfen Boş Geçmeyiniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Boş Geçmeyiniz")]
        public string İcon { get; set; }
        [Required(ErrorMessage = "Lütfen Boş Geçmeyiniz")]
        public string smailltitle { get; set; }
        [Required(ErrorMessage = "Lütfen Boş Geçmeyiniz")]
        public string Description { get; set; }
    }
}
