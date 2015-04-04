using System;

class After10Years
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your Birthday: ");
            Console.WriteLine("After ten years you'll be "+(DateTime.Now.Year - (DateTime.Parse(Console.ReadLine()).Year) + 10)+ " old");
            //int afterTenYears = (DateTime.Now.Year - birthDay.Year)+10;
            //Console.WriteLine("Now you are {0} old ", afterTenYears);
            //Console.WriteLine("After 10 years you will be {0} old", afterTenYears);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid birthday date(check your input)");
        }
        finally
        {
            Console.WriteLine("Have fun! You have time! Keep coding");        
        }
    }
}