using System;
using System.Linq;
using GeographyDB;
using System.Data.Entity;
using System.Xml.Linq;

namespace _03.ExportMonasteriesAsXML
{
    class Program
    {
        static void Main()
        {
            var context = new GeographyEntities();

            //Write a C# application based on your EF data model for exporting all monasteries by country to a XML file named monasteries.xml in the following XML format:

            var countries = context.Countries
                .Include(c => c.Monasteries)
                .Where(c => c.Monasteries.Any())
                .Select(c => new
                {
                    Name = c.CountryName,
                    Monasteries = c.Monasteries
                        .OrderBy(m => m.Name)
                        .Select(m => m.Name)
                })
                .OrderBy(c => c.Name)
                .ToList();
            
            var document = new XDocument();

            XElement countriesTag = new XElement("monasteries");

            foreach (var country in countries)
            {
                XElement countryTag = new XElement("country");
                countryTag.Add(new XAttribute("name", country.Name));
                foreach (var monastery in country.Monasteries)
                {

                    XElement monasteryTag = new XElement("monastery", monastery);
                    countryTag.Add(monasteryTag);
                }

                countriesTag.Add(countryTag);
            }

            document.Add(countriesTag);
            document.Save(@"monasteries.xml");

            System.Diagnostics.Process.Start(@"monasteries.xml");
        }
    }
}
