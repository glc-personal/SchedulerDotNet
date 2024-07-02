using Scheduler.Core.Interfaces;
using Scheduler.Core.Models;

namespace Scheduler.ApplicationServices.Implementations
{
    public class DateService : IDateService
    {
        /// <summary>
        /// Get the current days of the week.
        /// </summary>
        /// <returns>List of CalendarDayViewModel elements.</returns>
        public List<CalendarDayViewModel> GetWeekDays()
        {
            var weekDays = new List<CalendarDayViewModel>();
            var startDate = DateTime.Now.Date;

            for (int i = 0; i < 7; i++)
            {
                var currentDate = startDate.AddDays(i);
                weekDays.Add(new CalendarDayViewModel
                {
                    DayNumber = currentDate.Day,
                    DayName = currentDate.DayOfWeek.ToString()
                });
            }

            return weekDays;
        }

    }
}
