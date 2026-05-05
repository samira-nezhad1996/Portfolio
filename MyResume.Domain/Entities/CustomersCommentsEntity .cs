using Domain.Entities.Common;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class CustomersCommentsEntity : BaseEntity
    {
      
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Profession { get; set; }
        public StarRating Stars { get; set; }
        public string CommenterUrl { get; set; }
    }
}
