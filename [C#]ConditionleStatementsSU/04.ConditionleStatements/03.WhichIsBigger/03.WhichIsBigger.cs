using System;

class WhichIsBigger
{
    static void Main()
    {
        Console.WriteLine("Enter Three numbers...");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Numbers is  {0} __ {1} __ {2} \r\n \r\n", a, b, c);
        if (a > b && a > c)
        {
            Console.WriteLine("Bigger is {0}", a);
            Console.WriteLine("_________");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("Bigger is {0}", b);
            Console.WriteLine("_________");
        }
        else
        {
            Console.WriteLine("Biugger is {0}", c);
            Console.WriteLine("_________");
        }
    }
}