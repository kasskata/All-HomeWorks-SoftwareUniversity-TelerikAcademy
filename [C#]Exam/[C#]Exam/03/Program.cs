using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] batman = new char[(n * 4) + (n - 1), n];


            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write(" " + (new string('*', (n * 2) - 2)) + " " + new string(' ', n - 1) + " " + (new string('*', (n * 2) - 2)) + " ");
                }
                if (i != 1 && i != n && i != n / 2 + 1)
                {
                    Console.Write("*" + (new string('/', (n * 2) - 2)) + "*" + new string(' ', n - 1) + "*" + (new string('/', (n * 2) - 2)) + "*");
                }
                if (i == n / 2 + 1)
                {
                    Console.Write("*" + (new string('/', (n * 2) - 2)) + "*" + new string('-', n - 1) + "*" + (new string('/', (n * 2) - 2)) + "*");
                }
                Console.WriteLine();
            }
        }
    }
}