using System;
//Write a program that prints all the numbers from 1 to N,
//that are not divisible by 3 and 7 at the same time.
class NotDivideToThreeAndSeven
{
    static void Main()
    {
        for (int repeater = 0; repeater < 10; repeater++)
        {
            Console.Write("N= ");
            int n = int.Parse(Console.ReadLine());
            for (int counter = 1; counter <= n; counter++)
            {
                bool count = true;
                if (counter % 3 == 0)
                {
                    count = false;
                }
                else if (counter % 7 == 0)
                {
                    count = false;
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}