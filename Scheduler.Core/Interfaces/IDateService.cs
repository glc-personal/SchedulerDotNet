using Scheduler.Core.Models;

namespace Scheduler.Core.Interfaces
{
    public interface IDateService
    {
        List<CalendarDayViewModel> GetWeekDays();
    }
}
