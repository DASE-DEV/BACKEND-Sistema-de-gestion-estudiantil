using EduLIM.Domain.Abstractions.Base;

namespace EduLIM.Domain.Entities
{
    public class Subject : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Year { get; set; }
        public int Semester { get; set; }
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; } = null!;
        public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();
        public virtual ICollection<ProfessorSubject> ProfessorSubjects { get; set; } = new List<ProfessorSubject>();
        public virtual ICollection<UserSubject> UserSubjects { get; set; } = new List<UserSubject>();
    }
}
