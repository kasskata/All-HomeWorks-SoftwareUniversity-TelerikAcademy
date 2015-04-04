using System;

//Write an expression that extracts from a given integer i the value of a given bit number b. 
//Example: i=5; b=2 => value=1.


class BitExtraction
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int i = int.Parse(Console.ReadLine()); //integer
        Console.Write("Enter a Bit position: ");
        int b = int.Parse(Console.ReadLine()); //Bit position
        int mask = 1 << b;
        int NumberAndMask = mask & i;
        int bit = NumberAndMask >> b;
        Console.WriteLine(Convert.ToString(i, 2).PadLeft(32, '0'));
        Console.WriteLine("Extraction bit value: "+ bit);       
    }
}