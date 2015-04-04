using System;

//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that
//reads 3 integers from the console and prints the biggest of them using the method GetMax().

    class GetMaxMethod
    {
        //do the method
        static int GetMax(int firstNumber,int Second)
        {
            int max = Math.Max(firstNumber,Second);
            return max;
        }
        //calibrate the a b c integers and print the bigest
        static void Main()
        {
            Console.Write("First: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Second: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Thirth: ");
            int c = int.Parse(Console.ReadLine());

            int maxAB = GetMax(a, b);
            int maxAC = GetMax(a, c);
            int maxBc = GetMax(b, c);

            Console.WriteLine(GetMax(maxAB, (GetMax(maxAC, maxBc))));
        }
    }