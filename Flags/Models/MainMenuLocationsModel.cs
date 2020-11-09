using System;
using System.Collections.Generic;

namespace Flags.Models
{
    public class MainMenuLocationsModel
    {
        public List<Location> Locations { get; set; } = new List<Location>();
        public string ScrollToName { get; set; }
    }
}
