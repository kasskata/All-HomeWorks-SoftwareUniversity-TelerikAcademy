using System;
using System.Numerics;
//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//	N = 10 => N! = 3628800 => 2
//	N = 20 => N! = 2432902008176640000 => 4
//	Does your program work for N = 50 000?
//	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!


class FactorialZeroes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        decimal zeroCounter = 0;
        for (int counter = 1; counter <= n; counter++)
        {
            factorial *= counter;
        }
        Console.WriteLine(factorial);

        for (int counter = 1; counter <= n; counter++)
        {
            int devider = counter;
            while (devider % 5 == 0)
            {
                zeroCounter++;
                devider /= 5;
            }
        }
        Console.WriteLine(zeroCounter);
    }
}