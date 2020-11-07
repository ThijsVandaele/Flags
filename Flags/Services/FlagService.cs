using Flags.Models;
using System.Collections.Generic;
using System.IO;

namespace Flags.Services
{
    public class FlagService : IFlagService
    {
        public List<Flag> GetFlags(string source, bool firstTime = false)
        {

            var flags = new List<Flag>();

            var files = Directory.GetFiles(source);

            if (firstTime)
            {
                foreach (var file in files)
                {
                    var flag = new Flag
                    {
                        Path = file
                    };
                    flags.Add(flag);
                }
            }


            foreach (string d in Directory.GetDirectories(source))
            {
                files = Directory.GetFiles(d);

                foreach(var file in files)
                {
                    var flag = new Flag
                    {
                        Path = file
                    };
                    flags.Add(flag);
                }

                var f = GetFlags(d);
                flags.AddRange(f);
            }

            return flags;
        }

        public List<Location> GetLocations(string source, bool withFlags = false, int headerNr = 3)
        {
            var locations = new List<Location>();

            foreach (string d in Directory.GetDirectories(source))
            {
                var location = new Location
                {
                    Name = Path.GetFileName(d),
                    RelativePath = Path.GetRelativePath("wwwroot", d),
                    HeaderNr = headerNr
                };

                var files = Directory.GetFiles(d);
                location.AmountOfFlags = files.Length;

                var l = GetLocations(d, withFlags, headerNr + 1);

                location.Locations.AddRange(l);
                locations.Add(location);
            }

            return locations;
        }
    }
}
