using Microsoft.AspNetCore.Mvc;
using Scheduler.ApplicationServices.Interfaces;
using SchedulerDotNet.Models;

namespace SchedulerDotNet.Controllers
{
    public class TeamController : Controller
    {

        private readonly ILogger<TeamController> _logger;
        private readonly IUserService _userService;

        public TeamController(ILogger<TeamController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Team View Index action called");
            // Setup the Descriptor for the view
            var descriptor = new DescriptorViewModel
            {
                Title = "Team",
                Description = "Below you can find you and your team."
            };
            _logger.LogInformation("Team View - Descriptor setup with title: {Title} and Description: {Description}",
                descriptor.Title, descriptor.Description);

            // Get all users (change to get all users in a team later)
            var users = _userService.GetAllUsers();
            var viewModel = new TeamViewModel
            {
                Usernames = users.Select(u => u.Username).ToList(),
                Descriptor = descriptor
            };
            _logger.LogInformation("Team View - Users obtained with usernames: {usernames}",
                viewModel.Usernames);

            return View(viewModel);
        }
    }
}
