using Microsoft.EntityFrameworkCore;
using Scheduler.Core.Models;

namespace Scheduler.DataAccess
{
    public class SchedulerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Title> Titles { get; set; }

        public SchedulerDbContext(DbContextOptions<SchedulerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Title>().HasData(
                new Title { Id = 1, Name = "General Manager" },
                new Title { Id = 2, Name = "Manager" },
                new Title { Id = 3, Name = "Trainer" },
                new Title { Id = 4, Name = "Shift Lead" },
                new Title { Id = 5, Name = "Team Member" }
            );
        }
    }
}
