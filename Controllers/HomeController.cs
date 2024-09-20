using Microsoft.AspNetCore.Mvc;
using StatsWizard.Models;
using StatsWizard.Services;
using System.Diagnostics;
using System.Threading.Tasks;

namespace StatsWizard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StandingsService _standingsService;

        public HomeController(ILogger<HomeController> logger, StandingsService standingsService)
        {
            _logger = logger;
            _standingsService = standingsService;
        }

        public async Task<IActionResult> Index()
        {
            var standings = await _standingsService.GetStandingsAsync();
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
