using Domain.Entities.Common;

namespace Domain.Entities
{
    public class AboutMeEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int WorkYear { get; set; }
        public int CompletedProject { get; set; }
        public int Customers { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
