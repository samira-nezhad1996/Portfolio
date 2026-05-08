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
        [Required(ErrorMessage = "نام کامل الزامی است")]
        [StringLength(100, ErrorMessage = "نام حداکثر ۱۰۰ کاراکتر باشد")]
        [Display(Name = "نام کامل")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "ایمیل الزامی است")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        [StringLength(100)]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage = "شماره موبایل الزامی است")]
        [Phone(ErrorMessage = "شماره موبایل معتبر نیست")]
        [StringLength(15)]
        [Display(Name = "شماره موبایل")]
        public string Mobile { get; set; }
    }
}

