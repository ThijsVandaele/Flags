using Flags.Models;
using Flags.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Flags.Extensions;

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

        public ActionResult Click(string source)
        {
            var model = new ClickModel();

            var w = _env.WebRootPath;
            var flags = _flagService.GetFlags(Path.Combine(w, source), true);
            model.FlagsToShow.AddRange(flags);
            model.FlagsToAnswer.AddRange(flags);

            if (source == "Flags")
            {
                model.FlagsToShow.Shuffle();
                model.FlagsToAnswer.Shuffle();
            }
            else
            {
                model.FlagsToShow.ShuffleGood();
                model.FlagsToAnswer.Shuffle();
            }

            model.Source = source.Replace("//", " -> ");

            return View(model);
        }

        public ActionResult Type(string source)
        {
            var model = new TypeModel();

            var w = _env.WebRootPath;
            var flags = _flagService.GetFlags(Path.Combine(w, source), true);
            model.FlagsToShow.AddRange(flags);
            model.FlagsToAnswer.AddRange(flags);

            if (source == "Flags")
            {
                model.FlagsToShow.Shuffle();
                model.FlagsToAnswer.Shuffle();
            }
            else
            {
                model.FlagsToShow.ShuffleGood();
                model.FlagsToAnswer.Shuffle();
            }

            model.Source = source.Replace("//", " -> ");

            return View(model);
        }
    }
}