using System;

//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class CircleArea
{
    static void Main()
    {
        int CircleX = 5;
        int CircleY = 0;
        int area = CircleX * CircleX + CircleY * CircleY;
        Console.Write("Enter X: ");
        int RandomX = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y: ");
        int RandomY = int.Parse(Console.ReadLine());

        Console.WriteLine(area >= RandomX * RandomX + RandomY * RandomY);

    }
}
