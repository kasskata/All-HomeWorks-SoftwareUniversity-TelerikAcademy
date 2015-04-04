using System;


class TribonacciTriangle
{
    static void Main()
    {
        long First = long.Parse(Console.ReadLine());
        long second = long.Parse(Console.ReadLine());
        long thirth = long.Parse(Console.ReadLine());
        long N = long.Parse(Console.ReadLine());
        long result = 0;
        if (N == 1)
        {
            Console.WriteLine(First);
        }
        else if (N == 2)
        {
            Console.WriteLine(First);
            Console.WriteLine(second + " " + thirth);
        }
        else
        {
            Console.WriteLine(First);
            Console.WriteLine(second + " " + thirth);
            for (int row = 3; row <= N; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    result = First + second + thirth;
                    First = second;
                    second = thirth;
                    thirth = result;

                    Console.Write(result + " ");
                }
                Console.WriteLine();

            }
        }
    }
}