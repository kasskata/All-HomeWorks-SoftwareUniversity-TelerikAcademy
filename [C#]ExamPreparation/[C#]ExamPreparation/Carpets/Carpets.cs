using System;

class Carpets
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int elementOnLine = N;
        int center = elementOnLine / 2;

        for (int i = 1; i <= N/2; i++)
        {
            int position = 1;
            while (position <= N)
            {
                if (position <= center - i || position > center + i)
                {
                    Console.Write(".");
                    position++;
                }
                else
                {
                    for (int j = 0; j < i ; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("/");
                            position++;
                        }
                        else
                        {
                            Console.Write(" ");
                            position++;
                        }
                    }
                    for (int j = i ; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("\\");
                            position++;
                        }
                        else
                        {
                            Console.Write(" ");
                            position++;
                        }
                     }
                }
            }
            Console.WriteLine();
        }
        for (int i = N/2 ; i > 0; i--)
        {
            int position = 1;
            while (position <= N)
            {
                if (position <= center - i || position > center + i)
                {
                    Console.Write(".");
                    position++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("\\");
                            position++;
                        }
                        else
                        {
                            Console.Write(" ");
                            position++;
                        }
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("/");
                            position++;
                        }
                        else
                        {
                            Console.Write(" ");
                            position++;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}