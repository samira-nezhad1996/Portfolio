using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.LastWork
{
    public sealed record CreateLastWorkViewModel
    {
        [Required(ErrorMessage = "عنوان الزامی است.")]
        [Display(Name = "عنوان")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Display(Name = "توضیح کوتاه")]
        [StringLength(500)]
        public string? ShortDescription { get; set; }

        [Display(Name = "تاریخ شروع")]
        public DateTime StartDate { get; set; }

        [Display(Name = "تاریخ پایان")]
        public DateTime EndDate { get; set; }

        [Display(Name = "لوگو (URL)")]
        [DataType(DataType.Url)] 
        public string? Logo { get; set; }
    }
}
