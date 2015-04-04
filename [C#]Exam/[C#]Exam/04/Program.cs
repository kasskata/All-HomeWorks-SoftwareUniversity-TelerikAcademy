using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong sum = ulong.Parse(Console.ReadLine());
            ulong diff = ulong.Parse(Console.ReadLine());
            ulong count = 0;

            for (uint a = 5; a <=9; a++)
            {
                for (uint b = 5; b <=9; b++)
                {
                    for (uint c = 5; c <= 9; c++)
                    {
                        for (uint d = 5; d <= 9; d++)
                        {
                            for (uint e = 5; e <= 9; e++)
                            {
                                for (uint f = 5; f <= 9; f++)
                                {
                                    for (uint g = 5; g <= 9; g++)
                                    {
                                        for (uint h = 5; h <= 9; h++)
                                        {
                                            for (uint i = 5; i <= 9; i++)
                                            {
                                                if ((a + b + c + d + e + f + g + h + i) == sum)
                                                {
                                                    if (ulong.Parse((d + "" + e + "" + f)) - ulong.Parse((a + "" + b + "" + c)) == diff && ulong.Parse(g + "" + h + "" + i) - ulong.Parse(d + "" + e + "" + f) == diff)
                                                    {
                                                        Console.WriteLine(a + "" + b + "" + c + "" + d + "" + e + "" + f + "" + g + "" + h + "" + i);
                                                        count++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
