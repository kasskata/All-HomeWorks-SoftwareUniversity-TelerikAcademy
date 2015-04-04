using System;

class Score
{
    static void Main()
    {
        int Score = int.Parse(Console.ReadLine());

        switch (Score)
        {
            case 1:
                Console.WriteLine(Score*10);
                break;
            case 2:
                Console.WriteLine(Score * 10);
                break;
            case 3:
                Console.WriteLine(Score * 10);
                break;
            case 4:
                Console.WriteLine(Score * 100);
                break;
            case 5:
                Console.WriteLine(Score * 100);
                break;
            case 6:
                Console.WriteLine(Score * 100);
                break;
            case 7:
                Console.WriteLine(Score * 1000);
                break;
            case 8:
                Console.WriteLine(Score * 1000);
                break;
            case 9:
                Console.WriteLine(Score * 1000);
                break;
            default:
                Console.WriteLine("Invalid Score");
                break;
         }
    }
}