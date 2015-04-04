using System;

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
//34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to 
//ensure no precision is lost.

class FloatOrDouble
{
    static void Main()
    {
        double zNumber = 34.567839023;
        Console.WriteLine(zNumber);

        float aNumber = 12.345F;
        Console.WriteLine(aNumber);

        double bNumber = 8923.1234857;
        Console.WriteLine(bNumber);

        float cNumber = 3456.091F;
        Console.WriteLine(cNumber);

        decimal longNumber = 124311242542315.1342514617213237642388312543645345736833658376574727364642546254625372438273654823547165172161235M;
        //VS cut the number,couse is too big
        //Think and find HOW-TO print number like this(find BigInteger in Google).Its VERY VERY usefull)
        Console.WriteLine(longNumber);
    }
}
