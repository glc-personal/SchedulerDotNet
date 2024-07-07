using Scheduler.Core.Models;
using System.Collections.Generic;

namespace SchedulerDotNet.Models
{
    public class TeamViewModel
    {
        public List<string> Usernames { get; set; }
        public List<string> TeamMemberNames { get; set; }
        public List<string> TeamMemberTitles { get; set; }
        public List<User> Users { get; set; }
        public DescriptorViewModel Descriptor { get; set; }
        public List<ProfileStampViewModel> ProfileStamps { get; set; }
    }
}
