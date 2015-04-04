using System;

class PrimeNumbers
{
    static void Main()
    {
        for (int i = 7; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            if (i % 3 == 0)
            {
                continue;
            }
            else if (i % 5 == 0)
            {
                continue;
            }
            else if (i % 7 == 0)
            {
                continue;
            }
            Console.Write(i);
        }
    }
}
    