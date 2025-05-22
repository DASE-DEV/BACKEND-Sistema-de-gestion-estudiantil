using EduLIM.Domain.Abstractions.Base;

namespace EduLIM.Domain.Entities
{
    public class ProfessorSubject : Entity<int>
    {
        public int ProfessorId { get; set; }
        public int SubjectId { get; set; }
        public User Professor { get; set; }
        public Subject Subject { get; set; }
    }
}
