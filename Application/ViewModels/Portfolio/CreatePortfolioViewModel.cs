using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Portfolio
{
    public sealed record CreatePortfolioViewModel
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "عنوان الزامی است.")]
        [MaxLength(100, ErrorMessage = "عنوان نباید بیشتر از ۱۰۰ کاراکتر باشد.")]
        public string? Title { get; set; }

        [Display(Name = "توضیح کوتاه")]
        [MaxLength(500, ErrorMessage = "توضیح کوتاه نباید بیشتر از ۵۰۰ کاراکتر باشد.")]
        public string? ShortDescription { get; set; }

        [Display(Name = "تصویر")]
        public string? Picture { get; set; } 

        [Display(Name = "آدرس URL")]
        [Required(ErrorMessage = "آدرس URL الزامی است.")]
        [Url(ErrorMessage = "لطفاً آدرس URL معتبر وارد کنید.")]
        public string? Url { get; set; }
    }
}