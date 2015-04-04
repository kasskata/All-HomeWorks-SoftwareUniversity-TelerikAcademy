using System;
using System.Collections.Generic;

//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


class WorkingDays
{
    static void Main()
    {

        DateTime[] holidays = { new DateTime(2014, 12, 24), 
                                   new DateTime(2014, 12, 25), 
                                   new DateTime(2014, 12, 30),
                                   new DateTime(2014, 12, 31),
                                   new DateTime(2014, 01, 01) };

        Console.WriteLine(DateTime.Now.DayOfWeek-1);
        int day = new DateTime(2014, 12, 24).DayOfYear;
        int today = (DateTime.Today).DayOfYear;
        int between = day - today;
        List<DateTime> daysBetween = new List<DateTime>();

        for (int i = 0; i < between; i++)
        {
            DateTime tempDay = DateTime.Today.AddDays(i);
            for (int j = 0; j < holidays.Length-1; j++)
            {
                if (tempDay != holidays[j])
                {
                    if (tempDay.DayOfWeek != DayOfWeek.Saturday)
                    {
                        if (tempDay.DayOfWeek != DayOfWeek.Sunday)
                        {
                            daysBetween.Add(tempDay);
                        }
                    }
                }
            }
        }
        for (int i = 0; i < daysBetween.Count; i++)
        {
            Console.WriteLine(daysBetween[i]);
        }
    }
}