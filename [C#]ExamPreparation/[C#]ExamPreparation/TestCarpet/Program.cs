using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int dots = N / 2 - 1;
        int j = 0;
        for (int i = 1; i <= N / 2; i++)
        {
            Console.Write(new string('.', dots));
            dots--;
            for (j = 1; j < N / 2 - dots; j++)
            {
                if (j % 2 != 0)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            for (int k = N / 2 + 1; k < N - dots; k++)
            {
                if (i % 2 != 0 )
                {
                    if (k % 2 != 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else if (i % 2 == 0)
                {
                    if (k % 2 != 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("\\");
                    }
                }
            }
            Console.Write(new string('.', dots + 1));
            Console.WriteLine();
        }
        dots = 0;
        j = 0;

        for (int i = 1; i <= N / 2; i++)
        {
            Console.Write(new string('.', dots));
            dots++;

            for (int k = N / 2; k <= N - dots; k++)
            {
                if (i % 2 != 0)
                {
                    if (k % 2 != 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("\\");
                    }
                }
                else if (i % 2 == 0)
                {
                    if (k % 2 == 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            for (j = N / 2 ; j <= N - dots; j++)
            {
                if (i % 2 != 0)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else if (i % 2 == 0)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
            }
            Console.Write(new string('.', dots -1));
            Console.WriteLine();
        }
    }
}