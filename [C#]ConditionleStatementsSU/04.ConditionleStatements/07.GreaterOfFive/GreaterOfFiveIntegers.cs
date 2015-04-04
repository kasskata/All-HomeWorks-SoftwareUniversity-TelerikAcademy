using System;

//Write a program that finds the greatest of given 5 variables.


class GreaterOfFiveIntegers
{
    static void Main()
    {
        Console.WriteLine("Type 5 integer numbers: ");
        int box1 = int.Parse(Console.ReadLine());
        int box2 = int.Parse(Console.ReadLine());
        int box3 = int.Parse(Console.ReadLine());
        int box4 = int.Parse(Console.ReadLine());
        int box5 = int.Parse(Console.ReadLine());

        int biggestNumber = box1;

        if (biggestNumber < box2)
        {
            biggestNumber = box2;
        }
        if (biggestNumber < box3)
        {
            biggestNumber = box3;
        }
        if (biggestNumber < box4)
        {
            biggestNumber = box4;
        }
        if (biggestNumber < box5)
        {
            biggestNumber = box5;
        }
        Console.WriteLine("Bigest number is: " + biggestNumber);
    }
}