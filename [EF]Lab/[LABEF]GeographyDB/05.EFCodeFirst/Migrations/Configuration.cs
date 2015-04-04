namespace _05.EFCodeFirst.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<MountainsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "_05.EFCodeFirst.MountainsContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MountainsContext context)
        {
            if (context.Countries.Count() != 0
                && context.Mountains.Count() != 0
                && context.Peaks.Count() != 0)
            {
                return;
            }

            var countries = new List<Country>
            {
                new Country
                {
                    CountryCode = "BG",
                    CountryName = "Bulgaria"
                },
                new Country
                { 
                    CountryCode = "BG",
                    CountryName = "Germany"
                }
            };

            var mountains = new List<Mountain>
            {
                new Mountain
                {
                    Name = "Rila",
                    Peaks = new List<Peak>
                    {
                        new Peak
                        {
                            Name = "Musala",
                            Elevetaion = 2925
                        },
                        new Peak
                        { 
                             Name = "Malyovitsa",
                            Elevetaion = 2729
                        }
                    }
                },
                new Mountain
                {
                    Name = "Pirin",
                    Peaks = new List<Peak>
                    {
                        new Peak
                        {
                            Elevetaion = 2914,
                            Name = "Vihren"
                        }
                    }
                }
            };

            countries.ForEach(c => context.Countries.Add(c));
            mountains.ForEach(m => context.Mountains.Add(m));
            context.SaveChanges();
        }
    }
}
