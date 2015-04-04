using System.Diagnostics;
using System.IO;
using System.Linq;
using FootballDb;
using Newtonsoft.Json;

namespace _02.ToJSON
{
    class Program
    {
        static void Main()
        {
            var context = new FootballEntities();
            //exporting all leagues along with their teams Order the leagues and the teams in each league alphabetically.
            var leagues = context.Leagues
                .OrderBy(l => l.LeagueName)
                .Select(l => new
                {
                    leagueName = l.LeagueName,
                    Teams = l.Teams
                        .OrderBy(t => t.TeamName)
                        .Select(t => t.TeamName)
                });

            var leagueToJSON = JsonConvert.SerializeObject(leagues,Formatting.Indented);

            File.WriteAllText(@"leagues-and-teams.json", leagueToJSON);

            Process.Start(@"leagues-and-teams.json");
        }
    }
}
