

namespace Application.ViewModels.AboutMe
{
    public sealed record  AboutMeViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int WorkYear { get; set; }
        public int CompletedProject { get; set; }
        public int Customers { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
    }
}
