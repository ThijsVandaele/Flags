using Flags.Models;
using System;
using System.Collections.Generic;
namespace Flags.Services
{
    public interface IFlagService
    {
        List<Location> GetLocations(string source, bool withFlags = false, int headerNr = 3);
        List<Flag> GetFlags(string source, bool firstTime = false);
    }
}
