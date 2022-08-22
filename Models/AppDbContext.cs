using Microsoft.EntityFrameworkCore;

namespace WomenEmpowerment.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Ngo_Registration> Ngo_Registrations { get; set; }
        public DbSet<Provide> Provides { get; set; }
        public DbSet<Take> Takes { get; set; }
        public DbSet<Training_Course> Training_Courses { get; set; }
        public DbSet<Step_Registration> Step_Registrations { get; set; }

    }
}
