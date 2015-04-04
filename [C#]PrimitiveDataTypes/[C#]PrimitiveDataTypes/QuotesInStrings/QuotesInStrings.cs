using System;

class QuotesInStrings
{
    static void Main()
    {
        int quotes = (int)'"';//34
        char quote = '"';

        Console.WriteLine("The \"use\" of quotations causes difficulties.");
        Console.WriteLine("The {0}use{0} of quotations causes difficulties.", (char)quotes);
        Console.WriteLine("The " + quote + "use" + quote + " of quotations causes difficulties.");
        Console.WriteLine("This is number of Quotes in ASCI table" + quotes);
        Console.WriteLine();    
    }
}