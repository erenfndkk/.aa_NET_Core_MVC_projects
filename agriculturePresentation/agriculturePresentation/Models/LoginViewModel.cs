using System.ComponentModel.DataAnnotations;

namespace agriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="lütfen kullanıcı adı giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "lütfen şifre giriniz")]
        public string password { get; set; }
    }
}
