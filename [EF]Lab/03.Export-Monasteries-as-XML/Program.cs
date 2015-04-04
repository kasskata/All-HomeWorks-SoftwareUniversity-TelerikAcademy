using System;
using System.Linq;
using System.Xml.Linq;

namespace _03.Export_Monasteries_as_XML
{
    using Geography;

    class Program
    {
        static void Main()
        {

            var context = new GeographyEntities();

            var counties = context.Countries;

            var countriesQuery = counties
                .Where(c => c.Monasteries.Any())
                .OrderBy(c => c.CountryName)
                .Select(c => new
                {
                    c.CountryName,
                    Monasteries = c.Monasteries
                        .OrderBy(m => m.Name)
                        .Select(m => m.Name)
                });
            foreach (var country in countriesQuery)
            {
                Console.WriteLine("{0} {1}", country.CountryName, string.Join(", ", country.Monasteries));
            }

            var xmlMonasteries = new XElement("monasteries");

            foreach (var country in countriesQuery)
            {
                var xmlCountry = new XElement("country");
                xmlCountry.Add(new XAttribute("name", country.CountryName), country.Monasteries
                                                .Select(m => new XElement("monastery", m)));
                
                xmlMonasteries.Add(xmlCountry);
            }

            var xmlDoc = new XDocument(xmlMonasteries);
            xmlDoc.Save("monasteries.xml");

        }
    }
}
