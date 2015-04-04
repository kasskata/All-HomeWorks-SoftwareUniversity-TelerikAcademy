using System;
using System.Linq;

//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 


class MultriFunctionWithArrays
{
    static decimal[] FillTheArray(decimal[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = decimal.Parse(Console.ReadLine());
        }
        Array.Reverse(array);
        return array;
    }
    static void PrintPolynom(decimal[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] != 0)
            {
                if (i != 0 && i != 1)
                {
                    Console.Write("{2}{0}x^{1}", array[i], i, ReturnPositiveSign(array, i));
                }
                else if (i == 1)
                {
                    Console.Write("{1}{0}x", array[i], ReturnPositiveSign(array, i));

                }
                else if (i == 0)
                {
                    Console.Write("{1}{0}", array[i], ReturnPositiveSign(array, i));
                }
            }
        }
        Console.WriteLine();
    }
    static string ReturnPositiveSign(decimal[] arr, int i)
    {
        if (arr[i] > 0 && arr.Length - 1 != i)
        {
            string signPlus = "+";
            return signPlus;
        }
        else
        {
            return string.Empty;
        }
    }
    static decimal[] SumTwoArrays(decimal[] arr1, decimal[] arr2)
    {

        int biggerLength = arr1.Length;
        int smallerLength = arr2.Length;

        if (arr2.Length > arr1.Length)
        {
            biggerLength = arr2.Length;
            smallerLength = arr1.Length;
        }

        decimal[] sumArr = new decimal[biggerLength];

        for (int i = 0; i < biggerLength; i++)
        {
            if (i > smallerLength - 1)
            {
                sumArr[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
            }
            else
            {
                sumArr[i] = arr1[i] + arr2[i];
            }

        }
        return sumArr;
    }
    static decimal[] SubstractArrays(decimal[] arr1, decimal[] arr2)
    {

        int biggerLength = arr1.Length;
        int smallerLength = arr2.Length;

        if (arr2.Length > arr1.Length)
        {
            biggerLength = arr2.Length;
            smallerLength = arr1.Length;
        }

        decimal[] sumArr = new decimal[biggerLength];

        for (int i = 0; i < biggerLength; i++)
        {
            if (i > smallerLength - 1)
            {
                sumArr[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
            }
            else
            {
                sumArr[i] = arr1[i] - arr2[i];
            }
        }
        return sumArr;
    }

    static decimal[] MultiplyArr(decimal[] arr1, decimal[] arr2)
    {
        decimal[] multiArr = new decimal[arr1.Length + arr2.Length - 1];
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                multiArr[i + j] += arr1[i] * arr2[j];
            }

        }
        return multiArr;
    }

   

    

    static void Main()
    {
        Console.Write("Enter second polynomial's degree: ");
        int degree = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter factor [Higher to Lower]: ");
        decimal[] arr1 = new decimal[degree + 1];
        FillTheArray(arr1);

        Console.Write("Enter second polynomial's degree: ");
        degree = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter factor [Higher to Lower]: ");
        decimal[] arr2 = new decimal[degree + 1];
        FillTheArray(arr2);
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Array 1:" + new string('_',10));
        PrintPolynom(arr1);
        Console.Write("Array 2:" + new string('_', 10));
        PrintPolynom(arr2);
        Console.WriteLine();

        Console.Write("Sum:" + new string('_', 10));
        PrintPolynom(SumTwoArrays(arr1, arr2));


        Console.Write("Subtraction" + new string('_', 10));
        PrintPolynom(SubstractArrays(arr1, arr2));


        Console.Write("Multiplication:" + new string('_', 10));
        PrintPolynom(MultiplyArr(arr1, arr2));
        Console.WriteLine();
        Console.WriteLine();
    }
}