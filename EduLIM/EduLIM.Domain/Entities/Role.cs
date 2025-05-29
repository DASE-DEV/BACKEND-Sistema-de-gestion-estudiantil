using EduLIM.Domain.Abstractions.Base;

namespace EduLIM.Domain.Entities
{
    public class Role : Entity<int>
    {
        public required string Name { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; } = [];
    }
}
