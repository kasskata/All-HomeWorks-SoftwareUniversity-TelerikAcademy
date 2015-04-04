using System;
using System.Numerics;

class ApplesOrOranges
{
    static void Main()
    {
        BigInteger numberN = BigInteger.Parse(Console.ReadLine());
        string numberNstr = Convert.ToString(numberN);
        int oddNumbers = 0;
        int evenNumbers = 0;

        for (int i = 0; i < numberNstr.Length; i++)
        {
           int currentNumber = int.Parse((numberNstr[i]).ToString());
            if (currentNumber%2==0)
            {
                evenNumbers += currentNumber;
            }
            else
            {
                oddNumbers += currentNumber;
            }
        }
        if (oddNumbers<evenNumbers)
        {
            Console.WriteLine("apples " +"{0}",evenNumbers);
        }
        else if (oddNumbers>evenNumbers)
        {
            Console.WriteLine("oranges " +"{0}",oddNumbers);
        }
        else if (oddNumbers==evenNumbers)
        {
            Console.WriteLine("both "+"{0}",oddNumbers);
        }        
    }
}
