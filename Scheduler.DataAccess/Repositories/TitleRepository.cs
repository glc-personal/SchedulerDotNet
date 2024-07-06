using Scheduler.Core.Models;

namespace Scheduler.DataAccess.Repositories
{
    public class TitleRepository : Repository<Title>
    {
        public TitleRepository(SchedulerDbContext context) : base(context) { }
    }
}
