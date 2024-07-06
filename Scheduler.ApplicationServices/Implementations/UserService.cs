using Scheduler.Core.Models;
using Scheduler.ApplicationServices.Interfaces;
using Scheduler.DataAccess;

namespace Scheduler.ApplicationServices.Implementations
{
    public class UserService : IUserService
    {
        private readonly SchedulerDbContext _context;

        public UserService(SchedulerDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
