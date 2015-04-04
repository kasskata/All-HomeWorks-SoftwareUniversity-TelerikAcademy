using System;

//Declare five variables choosing for each of them the most appropriate of the types byte,
// sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
//52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. 
//Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.

class PropiertyTypes
{
    static void Main()
    {
        ushort number = 52130;
        Console.WriteLine(number);

        sbyte sbyteNumber = -115;
        Console.WriteLine(sbyteNumber);

        int intNumber = 4825932;
        Console.WriteLine(intNumber);

        byte byteNumber = 97;
        Console.WriteLine(byteNumber);
        
        short shortNumber = 10000;
        Console.WriteLine(shortNumber);
    }
}
