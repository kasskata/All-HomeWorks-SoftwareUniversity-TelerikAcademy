using System;

class Rectangles
{
    static void Main()
    {
        double width = 2.5;
        double height = 3;

        double perimeter = 2*width + 2*height;
        double area = width * height;

        Console.WriteLine("Perimeter = "+ perimeter);
        Console.WriteLine("Area = " + area);

    }
}