

namespace Application.ViewModels
{
    public sealed record  UserViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
