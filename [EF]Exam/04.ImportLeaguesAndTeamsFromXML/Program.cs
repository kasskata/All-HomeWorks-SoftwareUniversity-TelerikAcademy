using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using FootballDb;

namespace _04.ImportLeaguesAndTeamsFromXML
{
    class Program
    {
        static void Main()
        {
            var context = new FootballEntities();

            var document = XDocument.Load(@"../../leagues-and-teams.xml");
            var leagueTag = document.XPathSelectElements(@"/leagues-and-teams/league");

            var leagueList = new List<League>();

            foreach (var league in leagueTag)
            {
                try
                {
                    var leagues = CreateLeage(league, context);
                    leagueList.Add(leagues);
                    if (league.Element("teams") != null)
                    {
                        List<Team> teams = createTeams(league, context, leagues);
                        teams.ForEach(t => context.Teams.Add(t));
                    }
                }
                catch (Exception)
                {
                    throw;
                }

            }

            foreach (var league in leagueList)
            {
                if (context.Leagues.Any(l => l.LeagueName != league.LeagueName))
                {
                    context.Leagues.AddOrUpdate(league);
                }
            }

            //context.SaveChanges();
        }

        private static List<Team> createTeams(XElement league, FootballEntities context, League leagues)
        {
            //List<Team> teams = new List<Team>();

            //if (league.Attribute("name")!=null)
            //{
            //    teams.Add(new Team()
            //{
            //    Country = context. league.Attribute("name").Value;
            //});
            //}

            

            return teams;
        }

        private static League CreateLeage(XElement league, FootballEntities context)
        {
            var val = league.Element("league-name").Value;

            if (val == null)
            {
                throw new Exception();
            }

            return new League
            {
                LeagueName = league.Value
            };
        }
    }
}
