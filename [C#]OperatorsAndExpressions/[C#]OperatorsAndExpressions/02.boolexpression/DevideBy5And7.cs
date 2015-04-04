using System;

//Write a boolean expression that checks for given integer if it can be divided
//(without remainder) by 7 and 5 in the same time.


class DevideBy5And7
{
    static void Main()
    {
        Console.Write("Enter one integer number: ");
        int a = 5;
        int b = 7;
        int RandomNumber = int.Parse(Console.ReadLine());

        int DevideOnFive = (RandomNumber % a);
        int DevideOnSeven = (RandomNumber % b);

        Console.WriteLine("{0} can devide on 5 & 7 -> {1}", RandomNumber, (DevideOnFive == DevideOnSeven));

    }
}