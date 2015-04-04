using System;
//Write a program that shows the sign (+ or -) of the product 
//of three real numbers without calculating it.
//Use a sequence of if statements.

class PlusOrMinus
{
    static void Main()
    {

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        Console.WriteLine(x * y * z);
        //zero check
        if ((x == 0) || (y == 0) || z == 0)
        {
            Console.WriteLine("0");
        }
        //if positive X
        if (x > 0)
        {
            if (y > 0)                            //+x-y (+-z)
            {
                if (z > 0)
                {
                    Console.WriteLine("+");
                }
                else
                    Console.WriteLine("-");
            }
            else if (y < 0)                       //+x-y (+-z)
            {
                if (z > 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
        //if negative x
        else if (x < 0)
        {
            if (y > 0)                              //-x+y (+-z)
            {
                if (z > 0)
                {
                    Console.WriteLine("-");
                }
                else
                    Console.WriteLine("+");
            }
            else if (y < 0)                         //-x-y (+-z)
            {
                if (z > 0)
                {
                    Console.WriteLine("+");
                }
                Console.WriteLine("-");
            }
        }

    }
}