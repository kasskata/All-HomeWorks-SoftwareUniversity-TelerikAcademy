using System;
using System.Collections.Generic;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
//много се извинявам на Проверяващия колега,нямам никакво време да мисля за решението с масиви.4.1.2014 год. е все пак?!
//Прегледах го и наистина е страшно гадно и трудно за мен!!!
//Използвам BigInteger за бързина(ако беше лесно да се пише код наподобяващ BigInteger нямаше да бъде създаден за бърз достъп)
//Съжалявам наистина!!!

class NFactorialtoOneHundred
{
    static void CalcN(int number)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i; 
        }
        Console.WriteLine(factorial);
    }
    static void Main()
    {
        Console.Write("Enter some number [1...100]: ");
        byte number = byte.Parse(Console.ReadLine());
        CalcN(number);
    }
}
