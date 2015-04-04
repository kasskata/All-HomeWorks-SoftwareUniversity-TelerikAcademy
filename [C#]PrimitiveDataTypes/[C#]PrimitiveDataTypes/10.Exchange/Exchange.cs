using System;

//Declare two integer variables a and b and assign them with 5 and 10 and after 
//that exchange their values. Print the variable values before and after the exchange.

class Exchange
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int exchange;

        //very important "ALGORITHM" remember it !
        exchange = a;
        a = b;
        b = exchange;
        Console.WriteLine("a={0}\nb={1}",a,b);
    }
}
