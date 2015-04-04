using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class SystemMath
{
    static void Main()
    {
        Console.WriteLine("Side Side and an altitude to it: ");
        Console.WriteLine("area = "+45.321 * 34.1345 / 2); //<<<<change values if u want
        Console.WriteLine();
        Console.WriteLine("Three sides:");
        double area2 = (double)(34.13 + 41.67 + 12.78) / 2; //<<<<change values if u want
        Console.WriteLine("area = " + (double)Math.Sqrt(area2 * (area2 - 34.13) * (area2 - 41.67) * (area2 - 12.78)));//<<<<change values if u want
        Console.WriteLine();
        Console.WriteLine("Two sides and an angle between them: ");
        Console.WriteLine("area = " + 78.23 * 45.78 * Math.Sin(Math.PI * 47 / 180) / 2);//<<<<change values if u want
    }
}