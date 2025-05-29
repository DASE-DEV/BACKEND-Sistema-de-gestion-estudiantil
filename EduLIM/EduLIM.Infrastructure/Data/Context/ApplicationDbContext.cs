using EduLIM.Domain.Abstractions;
using EduLIM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduLIM.Infrastructure.Data.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IUnitOfWork
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ProfessorSubject> ProfessorSubjects { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Subject> Subjects  { get; set; }
        public DbSet<Submission> Submissions  { get; set; }
        public DbSet<User> Users  { get; set; }
        public DbSet<UserSubject> UserSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
