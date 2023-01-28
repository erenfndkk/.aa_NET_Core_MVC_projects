using System.ComponentModel.DataAnnotations;

namespace agriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz!!!")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Lütfen mail Giriniz!!!")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz!!!")]
        public string password { get; set; }
        [Required(ErrorMessage = "Şifreler uyumlu değil.")]
        [Compare("password", ErrorMessage = "Lütfen Kullanıcı Adını Giriniz!!!")]
        public string passwordConfirm { get; set; }
    }
}
