using System;

//Write a program that, depending on the user's choice inputs int, 
//double or string variable. If the variable is integer or double, 
//increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.

class UserChoiceSwitchStatement
{
    static void Main()
    {
        Console.WriteLine("Enter:");
        Console.WriteLine("\"1\" for desire type : int ");
        Console.WriteLine("\"2\" for desire type : double");
        Console.WriteLine("\"3\" for desire type : string");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                Console.WriteLine("enter *INT* number: ");
                int sum = int.Parse(Console.ReadLine());
                Console.WriteLine(sum +1);
                break;
            case 2:
                Console.WriteLine("Enter *DOUBLE* number: ");
                double sumD = double.Parse(Console.ReadLine() + 1);
                Console.WriteLine(sumD +1);
                break;
            case 3:
                Console.WriteLine("Enter *STRING* value: ");
                string sumS = Console.ReadLine();
                Console.WriteLine(sumS + " *");
                break;
        }

    }
}