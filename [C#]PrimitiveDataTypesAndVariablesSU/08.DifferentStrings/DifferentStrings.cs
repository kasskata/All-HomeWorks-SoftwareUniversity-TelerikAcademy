using System;
//Declare two string variables and assign them with following value:
//Do the above in two different ways: with and without using quoted strings.

class DifferentStrings
{
    static void Main()
    {        
        String WithQuotes="The \"use\" of quotations causes difficuties.";     //use\"for quotes
        object WithoutQuotes ="The use of quotations causes difficuties";    //usual text
        Console.WriteLine(WithQuotes);
        Console.WriteLine(WithoutQuotes);
    }
}