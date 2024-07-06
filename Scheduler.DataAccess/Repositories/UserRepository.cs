using Scheduler.Core.Models;

namespace Scheduler.DataAccess.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(SchedulerDbContext context) : base(context) { }
    }
}
