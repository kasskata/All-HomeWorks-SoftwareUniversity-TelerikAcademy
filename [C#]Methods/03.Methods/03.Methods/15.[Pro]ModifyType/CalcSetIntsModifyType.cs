using System;
using System.Linq;

//14
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.
//15
//* Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 
//Use generic method (read in Internet about generic methods in C#).

class CalcSetIntsModifyType
{
    static Random rnd = new Random();
    static void Minimum<T>(T[] arr)
    {
        Console.WriteLine("Minimum = "+ arr.Min());
    }
    static void Maximum<T>(T[] arr)
    {
        Console.WriteLine("Maximum = " + arr.Max());
    }
    static void Average<T>(T[] arr)
    {
        dynamic temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            temp += arr[i];
        }
        Console.WriteLine("Average = " + (double)((temp * 1.0) / arr.Length));
    }
    static void Sum<T>(T[] arr)
    {
        dynamic temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            temp += arr[i];
        }
        Console.WriteLine("Sum = "+ temp);
    }
    static void Product<T>(T[] arr)
    {
        dynamic product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        Console.WriteLine("Product = "+ product);
    }
    static void Main()
    {   
        Console.WriteLine("Int Version");
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            arr[i] = rnd.Next(1, 10);
        }
        Minimum(arr);
        Maximum(arr);
        Average(arr);
        Sum(arr);
        Product(arr);
        Console.WriteLine();
        Console.WriteLine("Double Version");
       
        double[] dArr = new double[10];
        for (int i = 0; i < 10; i++)
        {
            dArr[i] = rnd.NextDouble();
        }
        Minimum(dArr);
        Maximum(dArr);
        Average(dArr);
        Sum(dArr);
        Product(dArr);
    }
}