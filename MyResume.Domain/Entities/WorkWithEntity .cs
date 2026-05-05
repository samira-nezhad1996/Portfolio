using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class WorkWithEntity : BaseEntity
    {
     
        public string Title { get; set; }
        public string Logo { get; set; }
    }
}
