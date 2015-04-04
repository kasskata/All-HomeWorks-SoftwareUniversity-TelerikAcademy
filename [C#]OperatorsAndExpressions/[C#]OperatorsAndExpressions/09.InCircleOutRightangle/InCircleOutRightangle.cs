using System;

//Write an expression that checks for given point (x, y)
//if it is within the circle K( (1,1), 3) and out of the
//rectangle R(top=1, left=-1, width=6, height=2).

class InCircleOutRightangle
{
    static void Main()
    {
        double X = 2;
        double Y = 0.3;
        bool inCircle = (X - 1) * (X - 1) + (Y - 1) * (Y - 1) <= 9;
        bool outrectangle = ((-1 <= X) && (X <= 5) && (-1 <= Y) && (Y <= 1));
        Console.WriteLine("the points is");
        Console.WriteLine(inCircle ? "inside the circle" : "outside the circle");
        Console.WriteLine(outrectangle ? "inside rectangle" : "outside the rectangle");
    }
}
