using Flags.Models;
using Flags.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Flags.Controllers
{
    public class FlagController : Controller
    {
        private readonly IFlagService _flagService;
        private readonly IHostingEnvironment _env;

        public FlagController(IFlagService flagService, IHostingEnvironment env)
        {
            _flagService = flagService;
            _env = env;
        }

        public ActionResult Learn(string source)
        {
            var model = new LearnModel();

            var w = _env.WebRootPath;
            model.Flags = _flagService.GetFlags(Path.Combine(w, source), true);
            
            return View(model); 
        }
    }
}