using EduLIM.Domain.Abstractions.Base;

namespace EduLIM.Domain.Entities
{
    public class Program : Entity<int>
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
