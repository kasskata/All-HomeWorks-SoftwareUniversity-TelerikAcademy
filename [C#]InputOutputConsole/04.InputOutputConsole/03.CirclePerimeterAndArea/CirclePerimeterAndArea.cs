using System;

//Write a program that reads the radius r of a circle and prints its perimeter and 
//area formatted with 2 digits after the decimal point. Examples:

class CirclePerimeterAndArea
{
    static void Main()
    {
        try
        {
            Console.Write("Radius: ");
            double r = double.Parse(Console.ReadLine());
            double a = Math.PI * r * r;
            double p = 2 * (Math.PI * r);
            Console.WriteLine("Area: {0:0.00}", a);
            Console.WriteLine("Perimeter: {0:0.00}", p);
        }
        catch (FormatException)
        {
            Console.WriteLine("Cant Enter another symbols,only numbers!");
        }
    }
}