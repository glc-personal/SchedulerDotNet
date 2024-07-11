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

            // Setup the View's Right Section 
            SetupRightSection(viewModel);

            // Setup the View's Left Section
            SetupLeftSection(viewModel);

            return View(viewModel);
        }

        private void SetupRightSection(MetricsViewModel viewModel)
        {
            User user = viewModel.User;
            // Setup the Profile Stamp for this user
            ProfileStampViewModel profileStamp = new ProfileStampViewModel
            {
                ProfilePicturePath = user.ProfilePicturePath,
                Name = user.FirstName + " " + user.LastName,
                Title = user.Title,
            };
            viewModel.ProfileStamp = profileStamp;
        }

        private void SetupLeftSection(MetricsViewModel viewModel)
        {
            User user = viewModel.User;
            DescriptorViewModel overviewDescriptor = new DescriptorViewModel
            {
                Title = "Overview",
                Description = "Below you can find small summary metrics and information regarding your performance."
            };
            viewModel.OverviewDescriptor = overviewDescriptor;
            DescriptorViewModel hoursWorkedDescriptor = new DescriptorViewModel
            {
                Title = "Hours Worked",
                Description = "Below you can find a visual representation of your hours worked."
            };
            viewModel.HoursWorkedDescriptor = hoursWorkedDescriptor;
        }
    }
}
