using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

class SixHoursLater
{
    static void Main(string[] args)
    {
        DateTime time = new DateTime(2000, 5, 17, 23, 15, 25);
        time = time.AddHours(6.5);
        Console.WriteLine(time);
    }
}
