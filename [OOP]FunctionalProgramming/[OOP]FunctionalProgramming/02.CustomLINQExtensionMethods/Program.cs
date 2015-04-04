using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CustomLINQExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = new List<string>()
            {
                "mani!",
                "ebasi",
                "chudoto",
            };

            var whereNotCollection = collection
                .WhereNot<string>(t => t == "mani");

            //foreach (var i in whereNotCollection)
            //{
            //    Console.WriteLine(i);
            //}

            var repeatCollection = collection.Repeat<string>(5);

            //foreach (var i in repeatCollection)
            //{
            //    Console.WriteLine(i);
            //}

            var endsWith = collection.WhereEndsWith<string>(new string[]{"asi","!"});

            foreach (var i in endsWith)
            {
                Console.WriteLine(i);
            }
        }
    }
}
