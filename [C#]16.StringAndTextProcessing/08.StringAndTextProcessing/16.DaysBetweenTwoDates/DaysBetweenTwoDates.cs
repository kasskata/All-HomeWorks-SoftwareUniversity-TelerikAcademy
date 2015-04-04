using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days

class DaysBetweenTwoDates
{
    static void Main()
    {
         DateTime one = new DateTime(2000,1,1);
         DateTime two = new DateTime(1999,12,31);
         if (one < two)
         {
             DateTime exchange = one;
             one = two;
             two = exchange;
         }
         Console.WriteLine("{0:dd}",two-one);
    }
}
