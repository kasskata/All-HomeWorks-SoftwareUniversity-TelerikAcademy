using System;

class ThreeTasksSolve
{
    static void ReverseDigits()
    {
        Console.WriteLine("Enter Number: ");
        int num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            while (true)
            {
                Console.WriteLine("Invalid input,man!");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    break;
                }
            }
        }
        do
        {
            int reversed = num % 10;
            num = num / 10;
            Console.Write(reversed);
        }
        while (num != 0);
        Console.WriteLine();
    }

    static void AvgOfSeqOfInt()
    {
        Console.WriteLine("String's length: ");
        int length = int.Parse(Console.ReadLine());
        if (length == 0)
        {
            while (true)
            {
                Console.WriteLine("Invalid Values");
                length = int.Parse(Console.ReadLine());

                if (length != 0)
                {
                    break;
                }
            }
        }
        Console.WriteLine("Numbers:");
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write((length - i )+ "Left: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < length; i++)
        {

            sum = sum + arr[i];
        }
        float average = sum / 2;
        Console.WriteLine("Average: " + average);

    }

    static void LinerEquation()
    {
        Console.WriteLine("Enter number A[A!=0]: ");
        double a = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            while (true)
            {
                Console.WriteLine("Invalid Input!");
                a = double.Parse(Console.ReadLine());
                if (a != 0)
                {
                    break;
                }
            }
        }
        Console.WriteLine("Enter B:");
        double b = double.Parse(Console.ReadLine());
        double x;
        x = -b / a;
        Console.WriteLine("Result {0}", x);

    }


    static void Main()
    {
        Console.WriteLine("Pleese choose one of the three ");
        Console.WriteLine("1. Reverse");
        Console.WriteLine("2. Average Sequence");
        Console.WriteLine("3. Liner Equation");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: ReverseDigits();
                break;
            case 2: AvgOfSeqOfInt();
                break;
            case 3: LinerEquation();
                break;
        }
    }
}