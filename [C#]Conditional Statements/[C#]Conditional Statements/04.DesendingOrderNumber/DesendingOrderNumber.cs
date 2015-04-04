using System;

class DesendingOrderNumber
{
    static void Main()
    {
        for (int count = 0; count <= 20; count++)
        {
            Console.WriteLine("Enter 3 (three) different numbers to show you desendet order");
            Console.Write("Enter the first number:___");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:___");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the thirth number:___");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("Desending Order {0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("Desending Order {0} {1} {2}", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("Desending Order {0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("Desending Order {0} {1} {2}", b, c, a);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("Desending Order {0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("Desending Order {0} {1} {2}", c, b, a);
                }
            }
            else
            {
                Console.WriteLine("I said diffrent numbers _)_ are u blind oO ?! ");
            }
        }
    }
}