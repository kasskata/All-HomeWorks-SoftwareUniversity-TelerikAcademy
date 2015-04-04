using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

class Program
{
    static void Main()
    {
        //I limit them because u will enter too many chars , it's annoing
        char[] charArray = new char[int.Parse(Console.ReadLine())]; // <= type here what u want
        char[] compareArray = new char[int.Parse(Console.ReadLine())];
        int maxlength = 0;

        //now enter all literals
        for (int index = 0; index <charArray.Length; index++)
        {
            Console.Write("CHAR Array: Enter some character ({0}left):", charArray.Length - index - 1);//I design this "left counter" alone :P 
            charArray[index] = char.Parse(Console.ReadLine());
        }
        for (int index = 0; index <compareArray.Length; index++)
        {
            Console.Write("COMPARE Array: Enter some character ({0}left):", compareArray.Length - index - 1);//I design this "left counter" alone :P 
            compareArray[index] = char.Parse(Console.ReadLine());
        }

        if (charArray.Length > compareArray.Length)
        {
            maxlength = charArray.Length;
        }
        else if (charArray.Length < compareArray.Length)
        {
            maxlength = compareArray.Length;
        }
        //Comparing leter by leter
        for (int index = 0; index < maxlength; index++)
        {
            if (charArray[index] < compareArray[index])
            {
                Console.WriteLine("First one from Arrays is first lexicographically");
                break;
            }
            if (charArray[index] > compareArray[index])
            {
                Console.WriteLine("Second one from Arrays is first lexicographically");
                break;
            }
            if (charArray.Length < compareArray.Length)
            {
                Console.WriteLine("First one from Arrays is first lexicographically");
                break;
            }
            if (charArray.Length > compareArray.Length)
            {
                Console.WriteLine("Second one from Arrays is first lexicographically");
                break;
            }
            if (charArray.Length == compareArray.Length &&
                charArray[index] == compareArray[index])
            {
                Console.WriteLine("Equals");
            }
        }
    }
}
