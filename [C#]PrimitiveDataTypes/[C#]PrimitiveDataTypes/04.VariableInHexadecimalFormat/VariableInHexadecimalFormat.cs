using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        //correct format stringing - {0:X} is hex representation of all numbers
        Console.WriteLine("{0:X}",254);
    }
}