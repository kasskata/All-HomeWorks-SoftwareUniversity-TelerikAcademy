using System;

class SumofNNumbers
{
    static void Main()
    {
        int sum = new Int32();

        for (int i = 0; i < int.MaxValue; i++)
        {
            Console.Write(" + ");
            sum += int.Parse(Console.ReadLine());
            Console.Write(" = "+sum);
        }
    }
}