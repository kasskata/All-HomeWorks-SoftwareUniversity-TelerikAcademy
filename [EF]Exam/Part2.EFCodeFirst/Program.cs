namespace Part2.EFCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Migrations;

    class Program
    {
        static void Main()
        {
            var context = new PhonebookDB();

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PhonebookDB, Configuration>());

            Console.WriteLine(context.Contacts.Count());
        }
    }
}
