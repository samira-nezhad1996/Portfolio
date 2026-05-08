namespace Application.ViewModels.LastWorks
{
    public sealed record LastWorkViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Logo { get; set; }


    }
}
