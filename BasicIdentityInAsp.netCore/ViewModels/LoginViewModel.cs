using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace BasicIdentityInAsp.netCore.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="نام کاربری را وارد نمایید")]
        [Display(Name ="نام کاربری")]
        public string UserName {  get; set; } =string.Empty;
        [Required(ErrorMessage ="کلمه عبور را وارد نمایید")]
        [DataType(DataType.Password)]
        [Display(Name ="کلمه عبور")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
