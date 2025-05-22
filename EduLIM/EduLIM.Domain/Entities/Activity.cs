using EduLIM.Domain.Abstractions.Base;

namespace EduLIM.Domain.Entities
{
    public class Activity : Entity<int>
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
