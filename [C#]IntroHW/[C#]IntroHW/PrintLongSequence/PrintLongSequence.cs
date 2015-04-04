using System;

class PrintLongSequence
{
    static void Main()
    {
        Console.Write("2");

        for (int i = 3; i <= 1000; i++)
        {
            Console.Write(", ");

            if (i % 2 != 0)
            {
                Console.Write("-{0}", i);
            }
            else
            {
                Console.Write(i);
            }
        }
        Console.WriteLine();
    }
}
