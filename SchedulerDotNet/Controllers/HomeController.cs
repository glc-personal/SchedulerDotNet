using Microsoft.AspNetCore.Mvc;
using SchedulerDotNet.Models;
using Scheduler.Core.Interfaces;
using System.Diagnostics;

namespace SchedulerDotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDateService _dateService;

        public HomeController(ILogger<HomeController> logger, IDateService dateService)
        {
            _logger = logger;
            _dateService = dateService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Preferences()
        {
            var weekDays = _dateService.GetWeekDays();
            return View(weekDays);
        }

        public IActionResult Team()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
