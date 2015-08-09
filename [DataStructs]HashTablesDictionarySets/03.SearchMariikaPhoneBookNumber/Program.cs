using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchMariikaPhoneBookNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter phone numbers");
            string[] input = Console.ReadLine().Split(new[] { '-', ' ', ' ', '=', '\n', '\t', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> phonebookDictionary = new Dictionary<string, string>();

            while (input[0] != "search")
            {
                try
                {
                    phonebookDictionary.Add(input[0], input[1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("This person don't have phone number entered corectly. Please try again.");
                }

                input = Console.ReadLine().Split(new[] { '-', ' ', ' ', '=', '\n', '\t', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("For stop type \"stop\".");
            var name = Console.ReadLine();

            StringBuilder output = new StringBuilder("========Contacts======\n");
            
            while (name != "stop")
            {
                if (phonebookDictionary.ContainsKey(name))
                {
                    output.AppendFormat("{0} -> {1}\n", name, phonebookDictionary[name]);
                }
                else
                {
                    output.AppendFormat("Contact {0} does not exist.\n", name);
                }
                
                name = Console.ReadLine();
            }

            Console.WriteLine(output);

            Console.WriteLine(!phonebookDictionary.ContainsKey("Mariika")
                ? "And you haven't Mariika's phone... Shame on you! "
                : "You have Mariika's phone!! Please send it to me !?");
        }
    }
}
