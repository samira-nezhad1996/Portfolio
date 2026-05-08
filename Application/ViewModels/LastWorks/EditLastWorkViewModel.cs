using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels.LastWorks
{
    public sealed record EditLastWorkViewModel
    {

        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Title الزامی است")]
        [StringLength(100, ErrorMessage = "Title حداکثر 100 کاراکتر باشد")]
        public string Title { get; set; } = default!;

        [Required(ErrorMessage = "ShortDescription الزامی است")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "StartDate الزامی است")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "EndDate الزامی است")]
        public string EndDate { get; set; }

        [Required(ErrorMessage = "Logo الزامی است")]
        public string Logo { get; set; }

    }
}
