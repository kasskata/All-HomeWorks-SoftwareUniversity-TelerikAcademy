using System;


class ForestRoad
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0, j = N-1 ; i < N; i++,j--)
        {
            Console.Write(new string('.',i));
            Console.Write('*');
            Console.Write(new string('.',j));
            Console.WriteLine();
        }
        for (int i = N - 1, j = 0; j < N; i--, j++)
        {
            if (j == 0)
            {
                continue;
            }
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', j));
            Console.WriteLine();
        }
    }
}
