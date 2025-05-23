namespace EduLIM.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int IdRole { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public virtual ICollection<ProfessorSubject> ProfessorSubjects { get; set; } = new List<ProfessorSubject>();
        public virtual ICollection<UserSubject> UserSubjects { get; set; } = new List<UserSubject>();
        public virtual ICollection<Submission> Submissions { get; set; } = new List<Submission>();
    }
}
