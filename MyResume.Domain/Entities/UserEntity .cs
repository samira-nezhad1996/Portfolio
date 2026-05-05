using Domain.Entities.Common;


namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
    }
}

