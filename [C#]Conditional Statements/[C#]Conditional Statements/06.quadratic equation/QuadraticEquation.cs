using System;

//Write a program that enters the coefficients a, b and c of a quadratic equation :
//a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter A:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter B:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter C:");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Sqrt((b * b) - (4 * a * c));
        double xPlus = ((-b) + d) / (2 * a);
        double xMinus = ((-b) - d) / (2 * a);

        if (a == 0)
        {
            Console.WriteLine("not a valid number");
        }

        if (d < 0)
        {
            Console.WriteLine("dont have roots");
        }
        else if (d == 0)
        {
            Console.WriteLine("have 1 root x={0}", ((-b) / (2 * a)));
        }
        else
        {
            Console.WriteLine("have 2 roots\r\n x ={0}", xPlus);
            Console.WriteLine("x={0}", xMinus);
        }
    }
}