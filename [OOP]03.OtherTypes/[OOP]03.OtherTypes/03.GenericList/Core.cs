using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _03.GenericList
{
    class Core
    {
        static void Main(string[] args)
        {
            GList<int> arr = new GList<int>(10);
            arr.Add(0);
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);
            arr.Add(8);
            arr.Add(9);
            arr.Insert(10,2);
            arr.Insert(321,2);
            arr.Insert(321, 2);

            Console.WriteLine(arr);
            arr.Remove(arr.Lenght); // Extension(Length)!!!
            Console.WriteLine(arr);
            arr.Remove(arr.Lenght);
            arr.Remove(arr.Lenght);
            arr.Remove(arr.Lenght);
            arr.Remove(arr.Lenght);
            Console.WriteLine(arr.Lenght);
            Console.WriteLine(arr.Find(10));
            Console.WriteLine(arr.IsContain(10));
            Console.WriteLine(arr);
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());

        }
    }
}
