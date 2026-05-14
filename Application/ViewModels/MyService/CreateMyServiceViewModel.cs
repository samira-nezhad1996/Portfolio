using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.MyService
{
    public sealed record CreateMyServiceViewModel
    {
        [Required(ErrorMessage = "عنوان الزامی است.")]
        [MaxLength(100, ErrorMessage = "عنوان نباید بیشتر از ۱۰۰ کاراکتر باشد.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "تصویر (لوگو) الزامی است.")]
        public string? Logo { get; set; }
    }
}