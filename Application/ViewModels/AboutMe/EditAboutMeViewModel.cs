
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels.AboutMe
{
    public sealed record  EditAboutMeViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "نام الزامی است")]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "توضیحات الزامی است")]
        public string? Description { get; set; }

        [Range(0, 100)]
        public int WorkYear { get; set; }

        [Range(0, int.MaxValue)]
        public int CompletedProject { get; set; }

        [Range(0, int.MaxValue)]
        public int Customers { get; set; }

        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "شماره موبایل معتبر نیست")]
        public string? Mobile { get; set; }
    }
}
