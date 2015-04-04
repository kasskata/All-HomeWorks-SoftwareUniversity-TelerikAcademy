using System;


class Circle
{
    static void Main()
    {
        Console.Write("Enter a value for x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for y: ");
        double y = double.Parse(Console.ReadLine());
        bool intheCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
        Console.Write("The point is ");
        Console.Write(intheCircle ? "within the circle " : "outside of the circle ");
    }
}
