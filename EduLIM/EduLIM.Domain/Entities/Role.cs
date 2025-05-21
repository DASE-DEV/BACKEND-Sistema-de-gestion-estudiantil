using EduLIM.Domain.Abstractions.Base;

namespace EduLIM.Domain.Entities
{
    public class Role : Entity<int>
    {
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

        public required virtual ICollection<UserRole> Roles { get; set; }
    }
}
