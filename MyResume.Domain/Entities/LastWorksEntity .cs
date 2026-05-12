using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class LastWorksEntity : BaseEntity
    {
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Logo { get; set; }
    }
}
