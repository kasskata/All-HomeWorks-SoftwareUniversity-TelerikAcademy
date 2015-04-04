using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main()
        {
            string leap = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            decimal output = 48;
            
            output = output - h;
            output = output * (decimal)3 / (decimal)4;
            output = output + (p * (decimal)2 / (decimal)3);
            output += h;

            if (leap == "leap")
            {
                output += ((decimal)15/100) * output;
            }
            else if (leap == "normal")
            {
                
            }
                Console.WriteLine((int)output);
        }

    }
}