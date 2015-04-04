using System.Linq;
using FootballDb;
using System.Data.Entity;
using System.Xml.Linq;

namespace _03.ExportInternationalMatchesAsXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new FootballEntities();
            //exporting all international matches and their Score 
            var matches = context.InternationalMatches
                .Select(m => new
                {
                    HomeCountry = m.Country1.CountryName,
                    HomeCountryCode = m.Country1.CountryCode,
                    AwayCountry = m.Country.CountryName,
                    AwayCountryCode = m.Country.CurrencyCode,
                    League = m.League.LeagueName,
                    Date = m.MatchDate,
                    Score = m.HomeGoals+ "-"+ m.AwayGoals
                })
                .OrderBy(m=>m.Date)
                .ThenBy(m=>m.AwayCountry)
                .ThenBy(m=>m.HomeCountry);
            //Order the matches by date (from the earliest) and by home country and away country alphabetically as second and third criteria.
            var document = new XDocument();

            XElement matchesTag = new XElement("matches");

  //          <match date-time="26-Jun-1994 11:35">
  //            <home-country code="BG">Bulgaria</home-country>
  //            <away-country code="GR">Greece</away-country>
  //            <Score>4-0</Score>
  //            </match>


            foreach (var match in matches)
            {
                XElement matchTag = new XElement("match");
                
                var homeTag = new XElement("home-country",match.HomeCountry);
                homeTag.Add(new XAttribute("code", match.HomeCountryCode));
                matchTag.Add(homeTag);

                var awayTag = new XElement("away-country", match.AwayCountry);
                awayTag.Add(new XAttribute("code", match.AwayCountryCode));
                matchTag.Add(awayTag);
                
                if (match.League != null)
                {
                    var leagueTag = new XElement("league", match.League);
                    matchTag.Add(leagueTag);
                }

                if (match.Score != "-")
                {
                    matchTag.Add(new XAttribute("date-time", match.Date.Value.ToString("dd MMMM, yyyy H:mm")));
                    
                    var scoreTag = new XElement("score", match.Score);
                    matchTag.Add(scoreTag);
                } 
                matchesTag.Add(matchTag);
            }

            document.Add(matchesTag);
            document.Save(@"international-matches.xml");

            System.Diagnostics.Process.Start(@"international-matches.xml");
        }
    }
}
