using System;

class PrintASequence
{
    static void Main()
    {
        Console.WriteLine("1,-2,3,-4,5,-6,7,-8,9,-10");

        Console.Write("2");
        for (int i = 3; i <= 10; i++)
        {
            Console.Write(", ");
         
            if (i % 2 != 0)
            {
                Console.Write("-{0}",i);
            }
            else
            {
                Console.Write(i);
            }
        }
        Console.WriteLine();
    }
}