using Scheduler.Core.Models;
using Scheduler.ApplicationServices.Interfaces;
using Scheduler.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Scheduler.ApplicationServices.Implementations
{
    public class UserService : IUserService
    {
        private readonly SchedulerDbContext _context;

        public UserService(SchedulerDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get a list of all users.
        /// </summary>
        /// <returns>List<User></returns>
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        /// <summary>
        /// Get a specific user by their Id.
        /// </summary>
        /// <param name="id">The unique identifier for the user</param>
        /// <returns>User</returns>
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
