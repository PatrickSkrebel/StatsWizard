﻿using Microsoft.AspNetCore.Mvc;
using StatsWizard.Models;
using StatsWizard.Services;
using System.Diagnostics;
using System.Threading.Tasks;

namespace StatsWizard.Controllers
{
    public class NBAController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StandingsService _standingsService;

        public NBAController(ILogger<HomeController> logger, StandingsService standingsService)
        {
            _logger = logger;
            _standingsService = standingsService;
        }

        public IActionResult NBAHome()
        {
            return View(); // This will look for Views/NBA/NBAHome.cshtml
        }


        public async Task<IActionResult> Standings()
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
