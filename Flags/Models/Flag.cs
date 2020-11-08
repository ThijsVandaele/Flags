using System.IO;
using System.Linq;

namespace Flags.Models
{
    public class Flag
    {
        public string Path { get; set; }
        public string Name => System.IO.Path.GetFileNameWithoutExtension(Path);
        public string RelativePath => System.IO.Path.GetRelativePath("wwwroot", Path);
        public string NameWithSpaces
        {
            get
            {
                var n = System.IO.Path.GetFileNameWithoutExtension(Path);
                return string.Concat(n.Select(x => char.IsUpper(x) || x == '(' || x == ')' ? " " + x : x.ToString())).TrimStart(' ');
            }
        }
    }
}
