using System;

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.


    class MultipliedWith5
    {
        static void Main()
        {
            int[] ArrayInitializating = new int[20]; //for fast check
            for (int counter = 0; counter < ArrayInitializating.Length; counter++)
            {
                //take the index and multipling with 5
                ArrayInitializating[counter] += counter * 5;
                Console.WriteLine(ArrayInitializating[counter]); // And write it to the console with ArrayInitializating[counter]
            }
        }
    }
