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
        public Program Program { get; set; }
    }
}
