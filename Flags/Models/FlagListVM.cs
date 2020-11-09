using System.Collections.Generic;

namespace Flags.Models
{
    public class FlagListVM
    {
        public List<Flag> Flags { get; set; } = new List<Flag>();
        public int Cols { get; set; } = 1;
        public bool ShowNames { get; set; }
    }
}
