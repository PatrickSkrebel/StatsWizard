using Microsoft.AspNetCore.Mvc;
using StatsWizard.Models;
using StatsWizard.Services;
using System.Diagnostics;
using System.Threading.Tasks;

namespace StatsWizard.Controllers
{
    public class NFLController : Controller
    {
        private readonly ILogger<NFLController> _logger; // Changed from HomeController to NFLController
        private readonly NFLStandingService _nflStandingService; // Changed to NFLStandingService

        public NFLController(ILogger<NFLController> logger, NFLStandingService nflStandingService)
        {
            _logger = logger;
            _nflStandingService = nflStandingService; // Adjusted service name
        }

        public IActionResult NFLHome()
        {
            return View(); // Looks for Views/NFL/NFLHome.cshtml
        }

        public async Task<IActionResult> Standings()
        {
            var standings = await _nflStandingService.GetStandingsAsync();
            return View(standings);
        }


        public IActionResult Privacy()
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
