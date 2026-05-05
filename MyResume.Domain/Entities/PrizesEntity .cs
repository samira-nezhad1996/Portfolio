using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class PrizesEntity : BaseEntity
    {
     
        public string Title { get; set; }
        public string StartYear { get; set; }
        public int Rank { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
    }
}
