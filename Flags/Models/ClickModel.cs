using System.Collections.Generic;
using System.Linq;

namespace Flags.Models
{
    public class ClickModel
    {
        public string Source { get; set; }
        public string BreadCrume
        {
            get
            {
                var parts = Source.Split("\\");
                var braedCrume = string.Empty;

                foreach(var p in parts)
                {
                    braedCrume += $"{string.Concat(p.Select(x => char.IsUpper(x) || x == '(' || x == ')' ? " " + x : x.ToString())).TrimStart(' ')} -> ";
                }

                return braedCrume.Substring(0, braedCrume.Length - 4);
            }
        }
        public List<Flag> FlagsToShow { get; set; } = new List<Flag>();
        public List<Flag> FlagsToAnswer { get; set; } = new List<Flag>();
    }
}
