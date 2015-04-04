using System;

//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p 
//from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1 => 13 (00001101)
//n = 5 (00000101), p=2, v=0  1 (00000001)


class ChangeBitValues
{
    static void Main()
    {
        Console.Write("number: ");
        int n = int.Parse(Console.ReadLine()); //number
        Console.Write("position: ");
        int p = int.Parse(Console.ReadLine()); //bit position
        Console.WriteLine("value(1/0): ");
        int v = int.Parse(Console.ReadLine()); //bit value
        
        int mask;
        int newNumber = 0;

        if (v == 1)
        {
            mask = 1 << p;
            newNumber = n | mask;
        }
        else 
        {
            mask = ~(1 << p);
            newNumber = n & mask;
        }
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("the New number is " + newNumber);

    }
}