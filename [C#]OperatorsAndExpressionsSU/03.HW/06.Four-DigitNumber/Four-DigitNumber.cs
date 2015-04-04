using System;

class Program
{
    static void Main()
    {
        int zero = (int)'0';
        int number = 2011;
        string sNumber = number.ToString();
        //I use array
        Console.Write("Sum is: ");
        Console.WriteLine((((int)sNumber[0]) - 48) + (((int)sNumber[1]) - 48) + (((int)sNumber[2]) - 48) + (((int)sNumber[3]) - 48));
        Console.Write("Backwards: ");
        for (int i = sNumber.Length-1; i >= 0; i--)
        {
            Console.Write(sNumber[i]);
        }
        Console.WriteLine();
        Console.WriteLine("last become first: "+sNumber[3]+"" + sNumber[0] +""+ sNumber[1] +""+ sNumber[2]);
        Console.WriteLine("Second and thirth " + sNumber[0] + "" + sNumber[2] + "" + sNumber[1] + "" + sNumber[3]);

    }
}