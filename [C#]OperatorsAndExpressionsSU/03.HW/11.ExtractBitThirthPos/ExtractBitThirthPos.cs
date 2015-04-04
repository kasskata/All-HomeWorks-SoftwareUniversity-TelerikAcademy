using System;

class ExtractBitThirthPos
{
    static void Main()
    {
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        int bitPosition = 3;
        int mask = 1;
        mask = mask << bitPosition;

        int addMask = number & mask;

        if (addMask != 0)
        {
            Console.WriteLine("The bit in position {0} is 1", bitPosition);
        }
        else
        {
            Console.WriteLine("The bit in position {0} is 0", bitPosition); 
        }

        string numberBinary = Convert.ToString(number, 2);
        string maskBinary = Convert.ToString(mask, 2);
        string addMaskBinary = Convert.ToString(addMask, 2);

        Console.WriteLine("{0,15} : number\n{1,15} : mask\n{2,15} : addMask", numberBinary, maskBinary, addMaskBinary);

    }
}
