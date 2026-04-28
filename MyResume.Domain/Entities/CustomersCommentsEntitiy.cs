using Domain.Entities.Common;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class CustomersCommentsEntitiy : BaseEntity
    {
      
        public string Name { get; set; }
        public string Comment { get; set; }
        public string profession { get; set; }
        public StarRating Starts { get; set; }
        public string CommenterUrl { get; set; }
    }
}
