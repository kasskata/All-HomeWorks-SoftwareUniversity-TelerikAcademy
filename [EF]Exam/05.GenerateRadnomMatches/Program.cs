using System;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using FootballDb;

namespace _05.GenerateRadnomMatches
{
    class Program
    {
        static void Main()
        {
            var context = new FootballEntities();


            var document = XDocument.Load(@"../../generate-matches.xml");
            var generatorTag = document.XPathSelectElements(@"/generate-random-matches");

            int counter = 0;

            foreach (var tag in generatorTag.Descendants("generate"))
            {

                string league = "no league";
                int count = 10;
                int maxGoals = 5;
                DateTime start = DateTime.Parse("1-Jan-2000");
                DateTime end = DateTime.Parse("31-Dec-2015");

                if (tag.Element("league") != null)
                {
                    league = tag.Element("league").Value;
                }

                if (tag.Attribute("generate-count") != null)
                {
                    count = int.Parse(tag.Attribute("generate-count").Value);
                }

                if (tag.Attribute("max-goals") != null)
                {
                    maxGoals = int.Parse(tag.Attribute("max-goals").Value);
                }

                if (tag.Element("start-date") != null)
                {
                    start = DateTime.Parse(tag.Element("start-date").Value);
                }

                if (tag.Element("end-date") != null)
                {
                    end = DateTime.Parse(tag.Element("end-date").Value);
                }

                var randGen = new Random();

                counter++;
                Console.WriteLine("Processing request #{0} ...",counter);
                for (int i = 0; i < count; i++)
                {
                    var teamcount = randGen.Next(1, context.Teams.Count());
                    var teamcount1 = randGen.Next(1, context.Teams.Count());

                    var randomTeam = context.Teams.Where(t => t.Id == teamcount).FirstOrDefault().TeamName;

                    var randomTeam1 = context.Teams.Where(t => t.Id == teamcount1).FirstOrDefault().TeamName;

                    Console.WriteLine("{0}: {1} - {2}: {3}-{4} ({5})", GetRandomDate(start, end).ToString("D"), randomTeam, randomTeam1, randGen.Next(0, maxGoals), randGen.Next(0, maxGoals), league);
                }
                Console.WriteLine();
            }
        }

        private static DateTime GetRandomDate(DateTime start, DateTime end)
        {
            var rand = new Random();
            var range = end - start;

            var randTimeSpan = new TimeSpan((long)(rand.NextDouble() * range.Ticks));

            return start + randTimeSpan;
        }
    }
}
