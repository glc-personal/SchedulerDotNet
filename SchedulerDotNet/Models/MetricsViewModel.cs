using Scheduler.Core.Models;

namespace SchedulerDotNet.Models
{
    public class MetricsViewModel
    {
        public User User { get; set; }
        public ProfileStampViewModel ProfileStamp { get; set; }
        public DescriptorViewModel OverviewDescriptor { get; set; }
        public MetricStampViewModel ConsecutiveDaysMetricStamp { get; set; }
        public MetricStampViewModel AvailableHoursMetricStamp { get; set; }
        public MetricStampViewModel MonthsWorkedMetricStamp { get; set; }
        public DescriptorViewModel HoursWorkedDescriptor { get; set; }
    }
}
