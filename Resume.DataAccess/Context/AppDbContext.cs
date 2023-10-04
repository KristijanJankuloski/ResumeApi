using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models;

namespace Resume.DataAccess.Context
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<UserResume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<EducationEntry> EducationEntries { get; set; }
        public DbSet<Certification> Certifications { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
