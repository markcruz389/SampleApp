using Microsoft.EntityFrameworkCore;
using SampleApp.DataAccess.Entities;

namespace SampleApp.Service
{
    public class SampleAppDbContext : DbContext
    {
        public SampleAppDbContext(DbContextOptions<SampleAppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserRole>().ToTable("UserRole");
        }
    }
}
