using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class ContactEntitiy : BaseEntity
    {
     
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Topic { get; set; }
        public string Message { get; set; }
    }
}
