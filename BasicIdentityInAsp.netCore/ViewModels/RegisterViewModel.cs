using System.ComponentModel.DataAnnotations;

namespace BasicIdentityInAsp.netCore.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "نام را وارد کنید.")]
        [StringLength(
        150,
        ErrorMessage = "نام نمی‌تواند بیشتر از 150 کاراکتر باشد.")]
        [Display(Name = "نام")]
        public string FullName { get; set; }=string.Empty;
        [Required(ErrorMessage = "نام کاربری را وارد کنید.")]
        [StringLength(
        150,
        ErrorMessage = "نام کاربری نمی‌تواند بیشتر از 150 کاراکتر باشد.")]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage ="ایمیل را وارد نمایید")]
        [EmailAddress(ErrorMessage ="ایمیل وارد شده معتبر نیست")]
        [Display(Name ="ایمیل")]
        public string Email { get; set; }=string.Empty;
        [Required(ErrorMessage = "کلمه عبور را وارد کنید.")]
        [StringLength(
        150,
        ErrorMessage = "کلمه عبور نمی‌تواند بیشتر از 150 کاراکتر باشد.")]
        [Display(Name = "کلمه عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "تایید کلمه عبور را وارد کنید.")]
        [StringLength(
        150,
        ErrorMessage = "تایید کلمه عبور نمی‌تواند بیشتر از 150 کاراکتر باشد.")]
        [Display(Name = "تایید کلمه عبور")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="کلمه عبور وارد شده یکسان نمیباشد")]
        public string ConfirmPassword { get; set; }=string.Empty;
    }
}
