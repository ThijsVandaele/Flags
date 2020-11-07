using System.Collections.Generic;
using System.Linq;

namespace Flags.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string NameWithSpaces
        {
            get
            {
                return string.Concat(Name.Select(x => char.IsUpper(x) || x == '(' || x == ')' ? " " + x : x.ToString())).TrimStart(' ');
            }
        }
        public string RelativePath { get; set; }
        public List<Location> Locations { get; set; } = new List<Location>();
        public int AmountOfFlags { get; set; }
        public int AmountOfFlagsChildren => Locations.Sum(x => x.AmountOfAllFlags);
        public int AmountOfAllFlags => AmountOfFlags + AmountOfFlagsChildren;
        public int HeaderNr { get; set; }
    }
}
