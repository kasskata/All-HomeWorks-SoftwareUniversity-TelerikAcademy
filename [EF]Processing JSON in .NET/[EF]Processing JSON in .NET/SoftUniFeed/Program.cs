using System;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SoftUniFeed
{
    class Program
    {
        static void Main()
        {
            var client = new WebClient();

            if (!File.Exists(@"Feed.xml"))
            {
                client.DownloadFile("https://softuni.bg/Feed/News", @"Feed.xml");
            }

            var xDoc = XDocument.Load(@"Feed.xml");
            var json = JsonConvert.SerializeXNode(xDoc, Formatting.Indented);

            if (!File.Exists(@"FeedToJson.json"))
            {
                File.WriteAllText(@"FeedToJson.json", json);
            }

            var jsonParsed = JObject.Parse(json);

            var item = jsonParsed["rss"]["channel"]["item"];
            
            var titles = item.Select(f => f["title"]).ToList();

            Console.WriteLine(string.Join(" \n",titles));
            
            System.Diagnostics.Process.Start("FeedToJson.json");

            var template = new
            {
                Guid = new
                {
                    IsPermaLink = string.Empty,
                    Text = string.Empty
                },
                Link = string.Empty,
                Title = string.Empty,
                Description = string.Empty,
                Updated = string.Empty
            };

            //var items = item.Select(f => f);
            //var titlesLikeObject = JsonConvert.DeserializeAnonymousType(JsonConvert.SerializeObject(items), template);

            //Console.WriteLine(titlesLikeObject);
            //if (!File.Exists(@"JsonToHtml.html"))
            //{
            //    File.WriteAllText(@"JsonToHtml.html", json);
            //}
        }
    }
}
