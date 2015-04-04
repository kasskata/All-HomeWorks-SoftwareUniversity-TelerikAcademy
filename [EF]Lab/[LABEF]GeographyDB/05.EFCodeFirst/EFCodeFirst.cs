using System;
using System.Data.Entity;
using System.Linq;
using _05.EFCodeFirst.Migrations;

namespace _05.EFCodeFirst
{
    class EFCodeFirst
    {
        static void Main(string[] args)
        {
            var context = new MountainsContext();

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MountainsContext, Configuration>());

            Console.WriteLine(context.Countries.Count());
        }
    }
}
