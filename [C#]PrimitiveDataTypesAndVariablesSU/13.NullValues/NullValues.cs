using System;

//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.


class NullValues
{
    static void Main()
    {
        int? ValueI = null;
        double? ValueD = null;
        Console.WriteLine(ValueI +"Nothing");
        Console.WriteLine(ValueD + "Nothing");
        Console.WriteLine(ValueI + 12 + "Nothing");
        Console.WriteLine(ValueD + 56 + "Nothing");
        Console.WriteLine(ValueD + ValueI + "Nothing");
        Console.WriteLine(ValueD + null + "Nothing");
        Console.WriteLine(ValueI + null + "Nothing");
        //When operate with NULL,all Integer and double values is equal on NULL,when operate with NULL!!!
    }
}