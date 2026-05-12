using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.User
{
    public sealed record CreateUserViewModel
    {
        [Required(ErrorMessage = "نام و نام خانوادگی الزامی است.")]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "ایمیل الزامی است.")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل نامعتبر است.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "شماره موبایل الزامی است.")]
        [Phone(ErrorMessage = "فرمت شماره موبایل نامعتبر است.")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "رمز عبور الزامی است.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "رمز عبور باید حداقل ۶ کاراکتر باشد.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "تایید رمز عبور الزامی است.")]
        [Compare(nameof(Password), ErrorMessage = "رمز عبور و تایید آن مطابقت ندارند.")]
        public string ConfirmPassword { get; set; }
    }
}