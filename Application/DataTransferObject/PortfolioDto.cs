

namespace Application.DataTransferObject
{
    public sealed record PortfolioDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? Picture { get; set; }
        public string? Url { get; set; }
    }
}
