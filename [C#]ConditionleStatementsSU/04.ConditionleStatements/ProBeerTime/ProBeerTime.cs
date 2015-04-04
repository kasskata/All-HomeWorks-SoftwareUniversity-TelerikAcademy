using System;
using System.Globalization;
using System.Threading;
//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
//(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or 
//“non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
//Note that you may need to learn how to parse dates and times.
class Program
{
    static void Main()
    {
        Console.WriteLine("Plese, enter some beer hours!");
        DateTime time = DateTime.Parse(Console.ReadLine());
        if (time >= DateTime.Parse("13:00") || time <= DateTime.Parse("3:00"))
        {
            Random color = new Random();
            for (int i = 0; i < 121255125; i++)
            {
                //Enter valid value and watch! :D
                ConsoleColor random = (ConsoleColor)(color.Next(1, 16));
                Console.ForegroundColor = random;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(@"                     
                             .sssssssss.
                        .sssssssssssssssssss
                      sssssssssssssssssssssssss
                     ssssssssssssssssssssssssssss
                      @@sssssssssssssssssssssss@ss
                      |s@@@@sssssssssssssss@@@@s|s
               _______|sssss@@@@@sssss@@@@@sssss|s
             /         sssssssss@sssss@sssssssss|s
            /  .------+.ssssssss@sssss@ssssssss.|
           /  /       |...sssssss@sss@sssssss...|
          |  |        |.......sss@sss@ssss......|
          |  |        |..........s@ss@sss.......|
          |  |        |...........@ss@..........|
           \  \       |............ss@..........|
            \  '------+...........ss@...........|
             \________ .........................|
                      |.........................|
                     /...........................\
                    |.............................|
                       |.......................|
                           |...............|

              __   __  __  __     ___ . .    .  __   | | |
             |__) |_  |_  |__)     |  | |\  /| |_    | | |    
             |__) |__ |__ | \      |  | | \/ | |__   o o o " );
                Thread.Sleep(100);
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("Non-beer Time! Go Work");
        }
    }
}