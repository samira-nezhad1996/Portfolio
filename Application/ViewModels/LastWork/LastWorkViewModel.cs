using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.LastWork
{
    public sealed record class LastWorkViewModel
    {
            public Guid Id { get; set; }

            [Display(Name = "عنوان")]
            public string? Title { get; set; }

            [Display(Name = "توضیح کوتاه")]
            public string? ShortDescription { get; set; }

            [Display(Name = "تاریخ شروع")]
            public DateTime StartDate { get; set; } 

            [Display(Name = "تاریخ پایان")]
            public DateTime EndDate { get; set; }   

            [Display(Name = "لوگو")]
            public string? Logo { get; set; }
        
    }
}


