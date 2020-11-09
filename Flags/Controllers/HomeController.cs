using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Flags.Models;
using Flags.Services;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Flags.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFlagService _flagService;
        private readonly IHostingEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IFlagService flagService, IHostingEnvironment env)
        {
            _logger = logger;
            _flagService = flagService;
            _env = env;
        }

        public IActionResult Index(string scrollToName)
        {
            var w = _env.WebRootPath;
            var l = _flagService.GetLocations(Path.Combine(w, "Flags"));

            var model = new MainMenuLocationsModel
            {
                Locations = l,
                ScrollToName = scrollToName
            };

            return View(model);
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
