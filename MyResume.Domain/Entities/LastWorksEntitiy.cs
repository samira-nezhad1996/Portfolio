using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class LastWorksEntitiy : BaseEntity
    {
        
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Logo { get; set; }
    }
}
