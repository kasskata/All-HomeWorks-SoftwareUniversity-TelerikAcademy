using System;
//Write an if statement that examines two integer variables and
//exchanges their values if the first one is greater 
//than the second one.

class ExchangeValues
{
    static void Main()
    {
        int firstVariable = int.Parse(Console.ReadLine());
        int secondVariable = int.Parse(Console.ReadLine());
        int exchange;

        if (firstVariable > secondVariable)
        {
            exchange = firstVariable;
            firstVariable = secondVariable;
            secondVariable = exchange;
        }
        Console.WriteLine("biger number is {0}", secondVariable);
    }
}