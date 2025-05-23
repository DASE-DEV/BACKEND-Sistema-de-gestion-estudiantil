using EduLIM.Domain.Abstractions.Base;

namespace EduLIM.Domain.Entities
{
    public class UserRole : Entity<int>
    {
        public required int UserId { get; set; }
        public required int RoleId { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
    }
}
