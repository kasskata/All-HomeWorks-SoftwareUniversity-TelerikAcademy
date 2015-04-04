using System;

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

class FindTheThirthBit
{
    static void Main()
    {
        int number = 128615;
        int p = 3;
        string BitCode = Convert.ToString(number, 2).PadLeft(32, '0');

        int mask = 1 << p;
        int NumberAndMask = mask & number;
        int bit = NumberAndMask >> p;
        Console.WriteLine(@"
Number - {0} ;
Bit code - {1} ;
thirth bit - {2}.", number, BitCode, NumberAndMask);
    }
}