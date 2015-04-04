using System;
using System.Collections.Generic;

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] 
//contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
//С много помощ от Jasson


class SumBigNumbers
{
    static void PrintNumber(byte[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--) Console.Write(arr[i]);

        Console.WriteLine();
    }

    static byte[] New(byte[] a, byte[] b)
    {
        if (a.Length > b.Length) return New(b, a); 

        PrintNumber(a);
        PrintNumber(b);

        byte[] result = new byte[b.Length + 1];

        int i = 0, carry = 0;

        for (; i < a.Length; i++)
        {
            result[i] = (byte)(a[i] + b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length && carry != 0; i++)
        {
            result[i] = (byte)(b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length; i++)
        {
            result[i] = b[i];
        }

        if (carry != 0) result[i] = 1;
        else Array.Resize(ref result, result.Length - 1); 

        return result;
    }

    
    static List<int> AddRefactored(byte[] a, byte[] b)
    {
        var result = new List<int>(Math.Max(a.Length, b.Length));

        int carry = 0;
        for (int i = 0; i < result.Count; i++)
        {
            int currentDigit = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;

            carry = currentDigit / 10;
            result.Add(currentDigit % 10);
        }
        if (carry == 1) result.Add(1);

        return result;
    }

    static void Main()
    {
      PrintNumber(New(new byte[] { 7, 7 }, new byte[] { 5,6,4,4,3,2,7,8, }));
    }
}