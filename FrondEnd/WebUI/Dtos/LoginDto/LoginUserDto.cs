using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="kullanıcı adı giriniz!")]
        public  string UserName { get; set; }
        [Required(ErrorMessage = "Şifre giriniz!")]
        public string Password { get; set; }
    }
}
