using System;

//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.


class ExchangeValues
    {
        static void Main()
        {
            int LiteralA = 5;
            int LiteralB = 10;
            int ExchangeAB;      //AB=5

            Console.WriteLine(LiteralA);
            Console.WriteLine(LiteralB);
            Console.WriteLine("Exchange \r\n");
            ExchangeAB = LiteralA;
            LiteralA = LiteralB;
            LiteralB = ExchangeAB;
           
            Console.WriteLine(LiteralA);
            Console.WriteLine(LiteralB);
        }
    }