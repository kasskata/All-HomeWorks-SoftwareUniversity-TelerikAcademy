using System;

class Program
{
    static void Main()
    {
        double a = 55555;
        double b = 66666;
        //ternary operator
        Console.WriteLine(a<b ? a+","+b:b+","+a);
        //or
        if (a < b)
        {
            Console.WriteLine(a + "," + b);
        }
        else
        {
            Console.WriteLine(b + "," + a);
        }
    }
}
