using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class MyServicesEntity : BaseEntity
    {
   
        public string? Title { get; set; }
        public string? Logo { get; set; }
    }
}
