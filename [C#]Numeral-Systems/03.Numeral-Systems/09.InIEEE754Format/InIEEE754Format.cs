using System;


class InIEEE754Format
{
    static int LeftPoint(byte x)
    {
        return (x >> 4);
    }

    static int AfterPoint(byte x)
    {
        return (x & 15);
    }

    static string NibbleToBinary(int x)
    {
        string result = "";
        for (int i = 3; i >= 0; --i)
        {
            result += (x >> i) & 1;
        }

        return result;
    }

    static string ConvertFloatToBinary(float floatNumber)
    {
        string result = "";
        byte[] floatBytes = BitConverter.GetBytes(floatNumber);
        for (int i = 3; i >= 0; --i)
        {
            result += NibbleToBinary(LeftPoint(floatBytes[i]));
            result += NibbleToBinary(AfterPoint(floatBytes[i]));
        }

        return result;
    }

    static void Main()
    {
        float number = float.Parse(Console.ReadLine());

        string binaryNumber = ConvertFloatToBinary(number);

        Console.WriteLine("Sign: ");
        if (binaryNumber[0] == 0) Console.WriteLine("-");
        else Console.WriteLine("+");

        Console.WriteLine("Exponent: " + binaryNumber.Substring(1, 8));
        Console.WriteLine("Mantissa: " + binaryNumber.Substring(9));
    }
}
