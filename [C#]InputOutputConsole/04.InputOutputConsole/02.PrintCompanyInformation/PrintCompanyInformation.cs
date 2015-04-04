using System;

//A company has name, address, phone number, 
//fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

class PrintCompanyInformation
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter Company's info...");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Adress: ");
            string adress = Console.ReadLine();
            Console.Write("Phone: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax: ");
            string faxNumber = Console.ReadLine();
            Console.Write("WebSite: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager: ");
            string manager = Console.ReadLine();
            Console.WriteLine(new string('_', 40));
            Console.WriteLine("Name: " + name + "\nAdress:" + adress + "\nPhone number:" + phoneNumber + "\nFax: " + faxNumber + "\nWeb Site" + webSite + "\nManager: " + manager);
        }
        catch (FormatException)
        {
            Console.WriteLine("Cant Enter another symbols,only numbers!");
        }
    }
}
