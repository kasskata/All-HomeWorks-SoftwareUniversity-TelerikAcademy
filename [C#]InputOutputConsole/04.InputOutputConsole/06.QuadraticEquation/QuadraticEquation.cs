using System;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots)

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter 3 double numbers: ");
        double coefA = double.Parse(Console.ReadLine());
        double coefB = double.Parse(Console.ReadLine());
        double coefC = double.Parse(Console.ReadLine());

        double sqrtpart = coefB * coefB - 4 * coefA * coefC;
        
        //separate memory for future use !
        double x, x1, x2;

        if (sqrtpart > 0)
        {
            x1 = (-coefB + System.Math.Sqrt(sqrtpart)) / (2 * coefA);
            x2 = (-coefB - System.Math.Sqrt(sqrtpart)) / (2 * coefA);
            Console.WriteLine("Two Real Solutions: X1={0,8:f4} ,  X2= {1,8:f4}", x1, x2);
        }
        else if (sqrtpart < 0)
        {
            sqrtpart = -sqrtpart;
            x = -coefB / (2 * coefA);
            Console.WriteLine("No real roots");
        }
        else
        {
            x = (-coefB + System.Math.Sqrt(sqrtpart)) / (2 * coefA);
            Console.WriteLine("One Real Solution: X1 = X2 = {0,8:f4}", x);
        }
    }
}