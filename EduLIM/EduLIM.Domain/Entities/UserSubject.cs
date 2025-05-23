using EduLIM.Domain.Abstractions.Base;

namespace EduLIM.Domain.Entities
{
    public class UserSubject : Entity<int>
    {
        public int ProfessorId { get; set; }
        public int SubjectId { get; set; }
        public virtual User Student { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
