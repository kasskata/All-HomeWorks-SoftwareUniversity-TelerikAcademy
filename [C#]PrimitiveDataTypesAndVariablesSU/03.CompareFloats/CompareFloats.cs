using System;

//Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

    class CompareFloats
    {
        static void Main()
        {
            Console.WriteLine("enter first Float number");
            float LiteralA = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Float number");
            float LiteralB = float.Parse(Console.ReadLine());                               
          
          bool compare = (LiteralA==LiteralB);
           
          Console.WriteLine(compare);
        }
    }