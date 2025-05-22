using EduLIM.Domain.Abstractions.Base;
using System.Xml.Linq;
using System;

namespace EduLIM.Domain.Entities
{
    public class Submission : Entity<int>
    {
        public required string FileUrl { get; set; }
        public required string Comments { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int ActivityId { get; set; }
        public int StudentId { get; set; }
        public Activity Activity { get; set; } = null!;
        public User Student { get; set; } = null!;
    }
}
