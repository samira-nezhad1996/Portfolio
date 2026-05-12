using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.User
{
    public sealed record  EditUserViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "نام و نام خانوادگی الزامی است.")]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "ایمیل الزامی است.")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل نامعتبر است.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "شماره موبایل الزامی است.")]
        [Phone(ErrorMessage = "فرمت شماره موبایل نامعتبر است.")]
        public string Mobile { get; set; }
    }
}
