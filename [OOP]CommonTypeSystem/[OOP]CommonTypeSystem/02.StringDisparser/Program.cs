namespace _02.StringDisparser
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var strin1 = new StringDisparser("Pesho", "Kolio", "Gosho");
            var strin2 = new StringDisparser("Kolio", "Pesho", "Gosho");

            Console.WriteLine(strin1.Equals(strin2));

            foreach (var ch in strin2)
            {
                Console.Write(ch + " ");
            }


        }
    }
}
