using System;

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class ExchangeBitsPositions
{
    static void Main()
    {
        Console.Write("Enter number:");
        int n = int.Parse(Console.ReadLine());

        int mask = ~(7 << 3);

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        //Change bit position to zero
        n = n & mask;

        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        int newMask = n >> 21;

        Console.WriteLine(Convert.ToString(newMask, 2).PadLeft(32, '0'));

        int exitMask = 7 << 3;
        newMask = newMask & exitMask;

        Console.WriteLine(Convert.ToString(exitMask, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(newMask, 2).PadLeft(32, '0'));

        int newNumber = n | newMask;

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(newMask, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));

        Console.WriteLine("The new number is {0}", newNumber);
    }
}