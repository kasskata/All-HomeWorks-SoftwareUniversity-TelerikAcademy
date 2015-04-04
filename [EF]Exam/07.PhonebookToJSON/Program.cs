using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Part2.EFCodeFirst;

namespace _07.PhonebookToJSON
{
    class Program
    {
        static void Main()
        {

            string contactAsJSON = File.ReadAllText("../../contacts.json");
            var contacts = JArray.Parse(contactAsJSON);
            foreach (var contact in contacts)
            {
                try
                {
                    ImportContact(contact);
                    Console.WriteLine("Contact {0} imported", contact["name"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


        private static void ImportContact(JToken contactObj)
        {
            var context = new PhonebookDB();
            var contact = new Contact();

            if (contactObj["name"] == null)
            {
                throw new Exception("Missing name");
            }
            else
            {
                contact.Name = contactObj["name"].Value<string>();
            }

            if (contactObj["company"] != null)
            {
                contact.Company = contactObj["company"].Value<string>();
            }

            if (contactObj["position"] != null)
            {
                contact.Position = contactObj["position"].Value<string>();
            }

            if (contactObj["site"] != null)
            {
                contact.Url = contactObj["site"].Value<string>();
            }

            if (contactObj["notes"] != null)
            {
                contact.Notes = contactObj["notes"].Value<string>();
            }

            var phones = contactObj["phones"];

            if (phones != null)
            {
                contact.Phones = new List<Phone>();
                foreach (var phone in phones)
                {
                    string value = phone.Value<string>();
                    contact.Phones.Add(new Phone { PhoneNumber = value });
                }
            }

            var emails = contactObj["emails"];

            if (emails != null)
            {
                contact.Emails = new List<Email>();

                foreach (var email in emails)
                {
                    string value = email.Value<string>();

                    contact.Emails.Add(new Email { EmailContact = value });
                }
            }
            context.Contacts.Add(contact);
            context.SaveChanges();
        }
    }
}
