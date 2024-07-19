using Microsoft.AspNetCore.Mvc;
using Scheduler.ApplicationServices.Interfaces;
using Scheduler.Core.Models;
using SchedulerDotNet.Models;

namespace SchedulerDotNet.Controllers
{
    public class MetricsController : Controller
    {

        private readonly ILogger<MetricsController> _logger;
        private readonly IUserService _userService;

        public MetricsController(ILogger<MetricsController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            // Initialize the view model for this view
            MetricsViewModel viewModel = new MetricsViewModel();
            // Get the user (fixed to a single user id = 2 for now, need to change when login is featured)
            viewModel.User = await _userService.GetUserByIdAsync(2);
            if (viewModel.User == null)
            {
                return View("Error");
            }

            // Setup the View's Left Section 
            SetupLeftSection(viewModel);

            // Setup the View's Right Section
            SetupRightSection(viewModel);

            return View(viewModel);
        }

        private void SetupLeftSection(MetricsViewModel viewModel)
        {
            User user = viewModel.User;
            // Setup the Profile Stamp for this user
            ProfileStampViewModel profileStamp = new ProfileStampViewModel
            {
                ProfilePicturePath = user.ProfilePicturePath,
                Name = user.FirstName + " " + user.LastName,
                Title = user.Title,
                ProfilePictureWidth = "100px",
                ProfilePictureHeight = "100px",
            };
            viewModel.ProfileStamp = profileStamp;
        }

        private void SetupRightSection(MetricsViewModel viewModel)
        {
            User user = viewModel.User;
            DescriptorViewModel overviewDescriptor = new DescriptorViewModel
            {
                Title = "Overview",
                Description = "Below you can find small summary metrics and information regarding your performance."
            };
            viewModel.OverviewDescriptor = overviewDescriptor;

            MetricStampViewModel consecutiveDaysMetricStamp = new MetricStampViewModel
            {
                Metric = "Consecutive Days",
                IconPath = "/images/consecutive_days.png",
                Value = "33",
                Rank = "1st"
            };
            viewModel.ConsecutiveDaysMetricStamp = consecutiveDaysMetricStamp;

            MetricStampViewModel availableHoursMetricStamp = new MetricStampViewModel
            {
                Metric = "Available Hours",
                IconPath = "/images/available_hours.png",
                Value = "62",
                Rank = "2nd"
            };
            viewModel.AvailableHoursMetricStamp = availableHoursMetricStamp;

            MetricStampViewModel monthsWorkedMetricStamp = new MetricStampViewModel
            {
                Metric = "Months Worked",
                IconPath = "/images/months_worked.png",
                Value = "6",
                Rank = "14th"
            };
            viewModel.MonthsWorkedMetricStamp = monthsWorkedMetricStamp;

            DescriptorViewModel hoursWorkedDescriptor = new DescriptorViewModel
            {
                Title = "Hours Worked",
                Description = "Below you can find a visual representation of your hours worked."
            };
            viewModel.HoursWorkedDescriptor = hoursWorkedDescriptor;
        }
    }
}
