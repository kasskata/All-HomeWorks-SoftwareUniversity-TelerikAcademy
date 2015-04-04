using System;

class CircleRectangle
{
    static void Main()
    {
        Console.Write("Enter a value for x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for y: ");
        double y = double.Parse(Console.ReadLine());
        bool intheCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
        bool intheRectangle = ((-1 <= x) && (x <= 5)) && ((-1 <= y) && (y <= 1));
        Console.Write("The point is ");
        Console.Write(intheCircle ? "within the circle and " : "outside of the circle and ");
        Console.WriteLine(intheRectangle ? "within the rectangle." : "outside of the rectangle.");
    }
}
    
