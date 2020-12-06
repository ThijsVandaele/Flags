using Flags.Models;
using Flags.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Flags.Controllers
{
    public class MusicController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TrebleCleff()
        {
            return View();
        }

        public ActionResult ViolinNotes()
        {
            return View();
        }
    }
}
