using System;

//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} 
//of given 32-bit unsigned integer.

class ExchangeBitsPWithQ
{
    static void Main()
    {
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter number of bits to change (k):");
        int numbersBits = int.Parse(Console.ReadLine());

        Console.Write("Enter bit position for changed (p):");
        int changingBits = int.Parse(Console.ReadLine());

        Console.Write("Enter position of first bit to take.Must be greater than bit position:");
        int startingBit = int.Parse(Console.ReadLine());

        int maskOnes = 0;

        for (int i = 0; i < numbersBits; i++)
        {
            maskOnes = maskOnes << 1;
            maskOnes = maskOnes | 1;
        }

        Console.WriteLine(Convert.ToString(maskOnes, 2).PadLeft(32, '0'));

        int mask = ~(maskOnes << changingBits);

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        //Change bits p, p+1 ... to zeros
        number = number & mask;

        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        //Making a new mask with the bits we want to set
        int newMask = number >> startingBit;

        Console.WriteLine(Convert.ToString(newMask, 2).PadLeft(32, '0'));

        newMask = newMask & maskOnes;
        Console.WriteLine(Convert.ToString(maskOnes, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(newMask, 2).PadLeft(32, '0'));

        newMask = newMask << numbersBits;

        Console.WriteLine(Convert.ToString(newMask, 2).PadLeft(32, '0'));

        int newNumber = number | newMask;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(newMask, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));

        Console.WriteLine("The new number is {0}", newNumber);
    }
}