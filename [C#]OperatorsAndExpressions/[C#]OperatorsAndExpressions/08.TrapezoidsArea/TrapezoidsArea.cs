using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.


class TrapezoidsArea
    {
        static void Main()
        {
            float Base1 = 20;
            float base2 = 13;
            float Hight = 5;
            float area = ((Base1 + base2) / 2) * Hight;
            Console.WriteLine(area);
        }
    }