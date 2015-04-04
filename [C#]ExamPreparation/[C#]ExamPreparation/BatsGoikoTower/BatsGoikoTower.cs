using System;


class Program
{
    static void Main()
    {
        string stower = Console.ReadLine();
        int tower = int.Parse(stower);
        int outNumberDots = 0;
        int inNumberDots = 0;
        int devider = 1;
        int startSpecialPos = (tower - 1);
        int specialPos = startSpecialPos;
        for (outNumberDots = tower-1; outNumberDots >=0; outNumberDots--)
        {
            Console.Write(new string('.', outNumberDots));
            Console.Write('/');
            if (outNumberDots == specialPos)
            {
                Console.Write(new string('-', inNumberDots));
                specialPos = (specialPos) - devider;
                devider++;
            }
            else
            {
                Console.Write(new string('.', inNumberDots));
            }
            inNumberDots += 2;
            Console.Write('\\');
            Console.Write(new string('.', outNumberDots));
            Console.WriteLine();
        }

    }
}