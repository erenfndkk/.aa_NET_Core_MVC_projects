using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="lütfen kullanıcı adınızı giriniz")]
        public string Userame { get; set; }

        [Required(ErrorMessage = "lütfen şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
