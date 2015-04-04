using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.Sleep(150);
        string card = Console.ReadLine();
        
        switch (card)
        {
            case "2":
                Console.WriteLine("Yes");
                break;
            case "3":
                Console.WriteLine("Yes");
                break;
            case "4":
                Console.WriteLine("Yes");
                break;
            case "5":
                Console.WriteLine("Yes");
                break;
            case "6":
                Console.WriteLine("Yes");
                break;
            case "7":
                Console.WriteLine("Yes");
                break;
            case "8":
                Console.WriteLine("Yes");
                break;
            case "9":
                Console.WriteLine("Yes");
                break;
            case "10":
                Console.WriteLine("Yes");
                break;
            case "J":
                Console.WriteLine("Yes");
                break;
            case "D":
                Console.WriteLine("Yes");
                break;
            case "K":
                Console.WriteLine("Yes");
                break;
            case "A":
                Console.WriteLine("Yes");
                break;
            default:
                Console.WriteLine("No");
                break;
        }
    }
}