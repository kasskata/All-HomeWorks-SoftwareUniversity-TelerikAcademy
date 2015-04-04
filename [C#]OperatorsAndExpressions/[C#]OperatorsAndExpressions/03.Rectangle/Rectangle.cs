using System;

//Write an expression that calculates rectangle’s area by given width and height.

class Rectangle
{
    static void Main()
    {
        int height = 5467;
        int width = 547568;
        int RectangleArea = (height * width);

        Console.WriteLine("Rectangle's area with height {0} and width {1} is {2}", height, width, RectangleArea);
    }
}