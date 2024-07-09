using Microsoft.EntityFrameworkCore;
using BCrypt.Net;
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
            // Setup default titles for testing (need to be able to set titles as admin, not here)
            modelBuilder.Entity<Title>().HasData(
                new Title { Id = 1, Name = "General Manager" },
                new Title { Id = 2, Name = "Manager" },
                new Title { Id = 3, Name = "Trainer" },
                new Title { Id = 4, Name = "Shift Lead" },
                new Title { Id = 5, Name = "Team Member" }
            );

            // Setup the default user.
            var defaultUsers = new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "default-admin",
                    Password = BCrypt.Net.BCrypt.HashPassword("password"),
                    FirstName = "Sam",
                    LastName = "Tumaus",
                    Email = "sam.tumaus@gmail.com",
                    IsEmailConfirmed = false,
                    PhoneNumber = "302-507-9985",
                    IsPhoneConfirmed = false,
                    IsAdmin = true,
                    CreationDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    LastLoggedInDate = DateTime.Now,
                    Status = 0,
                    TitleId = 2,
                    Title = "Manager",
                    MinutesWorked = 0,
                    ConsecutiveDaysWorked = 0,
                    ProfilePicturePath = string.Empty,
                },
                // Team Member example user (needs to be removed after development)
                new User
                {
                    Id = 2,
                    Username = "test-team-member",
                    Password = BCrypt.Net.BCrypt.HashPassword("password1234!"),
                    FirstName = "Dillon",
                    LastName = "Sean",
                    Email = "dillon.sean@gmail.com",
                    IsEmailConfirmed = false,
                    PhoneNumber = "302-627-9281",
                    IsPhoneConfirmed = false,
                    IsAdmin = false,
                    CreationDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    LastLoggedInDate = DateTime.Now,
                    Status = 0,
                    TitleId = 5,
                    Title = "Team Member",
                    MinutesWorked = 0,
                    ConsecutiveDaysWorked = 0,
                    ProfilePicturePath = string.Empty,
                },
                new User
                {
                    Id = 3,
                    Username = "user3-test-team-member",
                    Password = BCrypt.Net.BCrypt.HashPassword("password"),
                    FirstName = "Kelly",
                    LastName = "Green",
                    Email = "kelly.green@gmail.com",
                    IsEmailConfirmed = false,
                    PhoneNumber = "717-090-4487",
                    IsPhoneConfirmed = false,
                    IsAdmin = false,
                    CreationDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    LastLoggedInDate = DateTime.Now,
                    Status = 0,
                    TitleId = 5,
                    Title = "Team Member",
                    MinutesWorked = 0,
                    ConsecutiveDaysWorked = 0,
                    ProfilePicturePath = string.Empty,
                },
                new User
                {
                    Id = 4,
                    Username = "user4-test-team-member",
                    Password = BCrypt.Net.BCrypt.HashPassword("password"),
                    FirstName = "Tom",
                    LastName = "Luc",
                    Email = "tom.luc@gmail.com",
                    IsEmailConfirmed = false,
                    PhoneNumber = "201-180-4464",
                    IsPhoneConfirmed = false,
                    IsAdmin = false,
                    CreationDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    LastLoggedInDate = DateTime.Now,
                    Status = 0,
                    TitleId = 5,
                    Title = "Team Member",
                    MinutesWorked = 0,
                    ConsecutiveDaysWorked = 0,
                    ProfilePicturePath = string.Empty,
                },
                new User
                {
                    Id = 5,
                    Username = "user5-test-team-member",
                    Password = BCrypt.Net.BCrypt.HashPassword("password"),
                    FirstName = "Gabby",
                    LastName = "Ballio",
                    Email = "gabby.ballio@gmail.com",
                    IsEmailConfirmed = false,
                    PhoneNumber = "132-343-5542",
                    IsPhoneConfirmed = false,
                    IsAdmin = false,
                    CreationDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    LastLoggedInDate = DateTime.Now,
                    Status = 0,
                    TitleId = 5,
                    Title = "Team Member",
                    MinutesWorked = 0,
                    ConsecutiveDaysWorked = 0,
                    ProfilePicturePath = string.Empty,
                }
            };
            modelBuilder.Entity<User>().HasData(defaultUsers);
        }
    }
}
