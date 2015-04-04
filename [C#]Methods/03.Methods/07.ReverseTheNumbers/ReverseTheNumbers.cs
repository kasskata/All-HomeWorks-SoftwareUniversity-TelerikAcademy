using System;

//Write a method that reverses the digits of given decimal number. Example: 256 > 652
 
    class ReverseTheNumbers
    {
        static void Reverse(params decimal[] array)
        {
           Array.Reverse(array);
        }
        static void Main()
        {
            decimal[] array = new decimal[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Fill the Array ({0} elemnt/s left) : ", array.Length - i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Reverse(array);
            Console.WriteLine("Reverse the array :");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write("," + array[i]);
            }
        }
    }
