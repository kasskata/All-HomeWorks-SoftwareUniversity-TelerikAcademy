namespace _EF_PerformanceInEntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Diagnostics;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            var context = new AdsEntities();
//01.Using Entity Framework write a SQL query to select all ads from the database and later print their title, status, category, town and user. Do not use Include(…) for the relationships of the Ads. Check how many SQL commands are executed with the SQL ExpressProfiler (or similar tool).
            //Problem01Include(context);

//02.Using Entity Framework select all ads from the database, then invoke ToList(), then filter the categories by status "Published", then select ad title, category and town, then invoke ToList() and finally order the ads by publish date. Rewrite the same in more optimized way and compare the performance.
            //Problem02ToList(context);

//03.Write a program to compare the execution speed between these two scenarios:
    //•	Select everything from the Ads table and print the ad title.
    //•	Select the ad title from Ads table.
            Problem03SelectAllInfoOrNeseceryInfo(context);

        }

        private static void Problem01Include(AdsEntities context)
        {
            Console.WriteLine("\n01. Include Join");
            var adsIncludeless = context.Ads;
            var adsInclude =
                context.Ads.Include(a => a.Category)
                    .Include(a => a.AdStatus)
                    .Include(a => a.Town)
                    .Include(a => a.AspNetUser);

            Print(adsInclude);
            Print(adsIncludeless);
        }

        private static void Problem02ToList(AdsEntities context)
        {
            Console.WriteLine("\n02. To List Properly");
            var watch = new Stopwatch();
            watch.Start();
            var allAdsFool = context.Ads.ToList().Where(a => a.AdStatus.Status == "Published").ToList().OrderBy(a => a.Date);
            watch.Stop();
            Console.WriteLine("Query with ToList() Like a noob: {0} Milliseconds", watch.ElapsedMilliseconds);
            watch.Reset();
            watch.Start();
            var allAdsSmart = context.Ads.Where(a => a.AdStatus.Status == "Published").OrderBy(a => a.Date).ToList();
            watch.Stop();
            Console.WriteLine("Query with ToList() Like a pro: {0} Milliseconds", watch.ElapsedMilliseconds);
        }

        private static void Problem03SelectAllInfoOrNeseceryInfo(AdsEntities context)
        {
            Console.WriteLine("\n03. Select only nesecery Data");

            var watch = new Stopwatch();

            watch.Start();
            var alladsInfo = context.Ads.ToList();
            watch.Stop();

            Console.WriteLine("Stupid mode: {0} milliseconds", watch.ElapsedMilliseconds);
            watch.Reset();

            watch.Start();
            var neseceryAdsInfoOnly = context.Ads.Select(a => a.Title).ToList();
            watch.Stop();

            Console.WriteLine("PRo Mode: {0} milliseconds", watch.ElapsedMilliseconds);
        }

        private static void Print(IQueryable<Ad> query)
        {
            foreach (var ad in query)
            {
                if (ad.Category != null && ad.Town != null)
                    Console.WriteLine("{0} {1} {2} {3} {4}", ad.Title, ad.AdStatus.Status, ad.Category.Name, ad.Town.Name, ad.AspNetUser.Name);
            }
        }
    }
}
