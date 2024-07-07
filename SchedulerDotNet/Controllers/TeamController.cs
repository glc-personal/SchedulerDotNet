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
            // Setup the Descriptor for the view
            var descriptor = new DescriptorViewModel
            {
                Title = "Team",
                Description = "Below you can find you and your team."
            };

            // Get all users (change to get all users in a team later)
            var users = _userService.GetAllUsers();
            // Setup the profile stamps for each user
            var profileStamps = new List<ProfileStampViewModel>();
            foreach (var user in users)
            {
                var profilePicturePath = user.ProfilePicturePath;
                if (profilePicturePath == string.Empty)
                {
                    profilePicturePath = "/images/user.png";
                }
                profileStamps.Add(new ProfileStampViewModel
                {
                    ProfilePicturePath = profilePicturePath,
                    Name = user.FirstName + " " + user.LastName,
                    Title = user.Title,
                });
            }

            // Setup the ViewModel for this View
            var viewModel = new TeamViewModel
            {
                Usernames = users.Select(u => u.Username).ToList(),
                TeamMemberNames = users.Select(u => u.FirstName + " " + u.LastName).ToList(),
                TeamMemberTitles = users.Select(u => u.Title).ToList(),
                Users = users,
                ProfileStamps = profileStamps,
                Descriptor = descriptor
            };

            return View(viewModel);
        }
    }
}
