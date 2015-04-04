using System;
using System.Linq;
using System.Web.Script.Serialization;

namespace ToJson
{
    using Geography;

    class Program
    {
        static void Main()
        {
            var context = new GeographyEntities();

            var rivers = context.Rivers
                .OrderByDescending(r => r.Length)
                .Select(r => new
                {
                    r.RiverName,
                    r.Length,
                    Countries = r.Countries
                        .OrderBy(c => c.CountryName)
                        .Select(c => c.CountryName)
                });

            var riversToJson = new JavaScriptSerializer();
            var result = riversToJson.Serialize(rivers.ToList());
            Console.WriteLine(result);

            System.IO.File.WriteAllText(@"rivers.json", result);

        }
    }
}
