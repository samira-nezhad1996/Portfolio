using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ResumeEntity : BaseEntity
    {
     
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Picture { get; set; }
        public string Url { get; set; }
    }
}
