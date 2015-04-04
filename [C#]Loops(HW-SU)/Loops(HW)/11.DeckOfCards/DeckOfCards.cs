using System;

//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.

class DeckOfCards
{
    static void Main()
    {
        Console.WriteLine("All cards from one deck (without Jockers cards):");
        int colorCounter;
        for (int counter = 2; counter <= 14; counter++)
        {
            switch (counter)
            {
                case 2:
                    Console.WriteLine("Two:");
                    break;
                case 3:
                    Console.WriteLine("Three:");
                    break;
                case 4:
                    Console.WriteLine("Four:");
                    break;
                case 5:
                    Console.WriteLine("Five:");
                    break;
                case 6:
                    Console.WriteLine("Six:");
                    break;
                case 7:
                    Console.WriteLine("Seven:");
                    break;
                case 8:
                    Console.WriteLine("Eight:");
                    break;
                case 9:
                    Console.WriteLine("Nine:");
                    break;
                case 10:
                    Console.WriteLine("Jack:");
                    break;
                case 11:
                    Console.WriteLine("Queen:");
                    break;
                case 12:
                    Console.WriteLine("King:");
                    break;
                case 13:
                    Console.WriteLine("Ace:");
                    break;
            }
            if (counter == 14)
            break;
            for (colorCounter = 1; colorCounter <= 4; colorCounter++)
            {

                switch (colorCounter)
                {
                    case 1:
                        Console.WriteLine("of spades " + (char)06);
                        break;
                    case 2:
                        Console.WriteLine("of heard " + (char)03);
                        break;
                    case 3:
                        Console.WriteLine("of diamonds " + (char)04);
                        break;
                    case 4:
                        Console.WriteLine("of clubs " + (char)05);
                        break;
                }
            }
        }
    }
}