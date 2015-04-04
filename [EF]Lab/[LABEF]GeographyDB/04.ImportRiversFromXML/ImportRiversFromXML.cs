using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace _04.ImportRiversFromXML
{
    using GeographyDB;

    class ImportRiversFromXML
    {
        static void Main()
        {
            var context = new GeographyEntities();
            var document = XDocument.Load(@"../../rivers.xml");
            var riversTag = document.XPathSelectElements(@"/rivers/river");
            var rivers = new List<River>();

            foreach (var xElement in riversTag)
            {
                rivers.Add(CreateRiver(xElement,context));
            }

            context.Rivers.AddRange(rivers);
            context.SaveChanges();
        }

        private static River CreateRiver(XElement xElement, GeographyEntities context)
        {
            try
            {
                var name = xElement.Element("name").Value;
                var length = int.Parse(xElement.Element("length").Value);
                var outflow = xElement.Element("outflow").Value;

                int? drainageArea = null;
                if (xElement.Element("drainage-area") != null)
                {
                    drainageArea = int.Parse(xElement.Element("drainage-area").Value);
                }

                int? averageDischarge = null;
                if (xElement.Element("average-discharge") != null)
                {
                    averageDischarge = int.Parse(xElement.Element("average-discharge").Value);
                }

                var countriesNames = xElement.XPathSelectElements(@"countries/country");
                var countriesPerRiver = countriesNames
                    .Select(countryName => context.Countries
                        .FirstOrDefault(c => c.CountryName == countryName.Value))
                        .ToList();

                return new River()
                {
                    RiverName = name,
                    Length = length,
                    Outflow = outflow,
                    DrainageArea = drainageArea,
                    AverageDischarge = averageDischarge,
                    Countries = countriesPerRiver
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
