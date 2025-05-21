namespace EduLIM.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int IdRole { get; set; }
        public ICollection<Role>? Roles { get; set; }
    }
}
