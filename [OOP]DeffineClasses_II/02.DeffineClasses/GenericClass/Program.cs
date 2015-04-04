namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        // Implement methods for adding element, accessing element by index, removing element by index, 
        //inserting element at given position, clearing the list, finding element by its value and ToString(). 
        static void Main()
        {
            Optimus<int> optimus = new Optimus<int>(10);

            for (int i = 0; i < 28; i++)
            {
                optimus.Add(i);
            }
            Console.WriteLine(optimus.Min());
            //optimus.Insert(0,5);
            // optimus.Clear();
            //optimus.Find();

            Console.WriteLine();
            //int batman = optimus[0];

        }
    }
}
