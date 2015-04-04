using System;


class NextDate
{
    static void Main()
    {
        int date = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        if (
            (date == 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
            || (date == 30 && (month == 4 || month == 6 || month == 9 || month == 11))
            || (date == 28 && month == 2)
            || (date == 29 && (month == 2) && (year == 2012 || year == 2008 || year == 2004 || year == 2000)))
        {
            date = 1;
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
        }
        else
        {
            date ++;
        }
        Console.WriteLine(date + "." + month + "." + year);
    }
}
