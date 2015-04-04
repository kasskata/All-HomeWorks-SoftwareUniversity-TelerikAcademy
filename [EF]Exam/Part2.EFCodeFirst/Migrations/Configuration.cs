using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Part2.EFCodeFirst.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PhonebookDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PhonebookDB context)
        {
            if (context.Contacts.Count() != 0)
            {
                return;
            }
            var seedList = new List<Contact>{
                new Contact
                {
                    Name = "Peter Ivanov",
                    Company = "Smart Ideas",
                    Notes = "Friend from school",
                    Position = "CTO",
                    Url = "http://blog.peter.com",
                    Emails = new List<Email>
                    {
                        new Email
                        {
                            EmailContact = "peter@gmail.com",
                        },
                        new Email
                        {
                            EmailContact = "peter_ivanov@yahoo.com"
                        }
                    },
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            PhoneNumber = "+359 2 22 22 22",
                        },
                        new Phone
                        {
                            PhoneNumber = "+359 88 77 88 99"
                        }
                    }
                },
                new Contact
                {
                    Name = "Maria",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            PhoneNumber = "+359 22 33 44 55"
                        }
                    }
                },
                new Contact
                {
                    Name = "Angie Stanton",
                    Emails = new List<Email>
                    {
                        new Email
                        {
                            EmailContact = "info@angiestanton.com"
                        }
                    },
                    Url = "http://angiestanton.com"
                }
            };

            seedList.ForEach(c => context.Contacts.Add(c));
            context.SaveChanges();
        }
    }
}
