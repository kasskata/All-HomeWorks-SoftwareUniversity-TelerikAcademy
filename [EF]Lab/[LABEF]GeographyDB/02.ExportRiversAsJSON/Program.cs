using System;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace _02.ExportRiversAsJSON
{
    using GeographyDB;

    class Program
    {
        static void Main()
        {
            var context = new GeographyEntities();
            var rivers = context.Rivers
                .Where(r => r.Countries.Any())
                .Select(r => new
                {
                    r.RiverName,
                    r.Length,
                    Counties = r.Countries
                        .OrderBy(c=>c.CountryName)    
                        .Select(c=>c.CountryName)
                })
                .OrderByDescending(r=>r.Length)
                .ToList();

            var riversAsJson = JsonConvert.SerializeObject(rivers,Formatting.Indented);

            File.WriteAllText(@"RiversJson.json",riversAsJson);
            System.Diagnostics.Process.Start(@"RiversJson.json");
        }
    }
}
