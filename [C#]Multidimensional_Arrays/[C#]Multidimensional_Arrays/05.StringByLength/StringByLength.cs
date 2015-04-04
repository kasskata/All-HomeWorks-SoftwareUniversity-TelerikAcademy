using System;
using System.Linq;

class StringByLength
{
    static void Main()
    {
        Console.WriteLine("filling the array");
        string[] array = new string[10];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("{0} left", array.Length - i );
            array[i] = Console.ReadLine();
        }
        foreach (var item in array.OrderBy(uStrings => uStrings.Length))
        {
            Console.WriteLine(item);
        }
    }
}
