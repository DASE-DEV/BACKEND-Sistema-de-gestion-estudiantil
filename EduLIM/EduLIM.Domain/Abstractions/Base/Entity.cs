namespace EduLIM.Domain.Abstractions.Base
{
    public class Entity<TKey>
    {
        public required TKey Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
