namespace Part2.EFCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhonebookDB : DbContext
    {
        public PhonebookDB()
            : base("name=Phonebook")
        {
        }

        public IDbSet<Contact> Contacts { get; set; }
        
        public IDbSet<Phone> Phones { get; set; }

        public IDbSet<Email> Emails { get; set; }
    }

//   •	Contacts have name and optionally position, company, emails, phones, site (URL) and notes (free text).
//  •	Emails hold email address.
//  •	Phones hold phone number
}