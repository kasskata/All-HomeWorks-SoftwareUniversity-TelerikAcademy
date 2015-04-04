namespace _05.SortingNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SortingNumbers
    {
        static void Main()
        {
            Console.Write("how many numbers u want? ");
            int n = int.Parse(Console.ReadLine());
            int count = new Int32();
            List<int> batman = new List<int>();

            while (count <= n)
            {
                Console.Write("Enter number: ");
                batman.Add(int.Parse(Console.ReadLine()));
                count++;
            }
            batman.Sort();
            PrintBatman(batman);
        }
        
        private static void PrintBatman(List<int> batman)
        {
            Console.WriteLine(new string('_', 40));
            Console.WriteLine(String.Join(",", batman));
            Console.WriteLine(new string('_', 40));
        }
    }
}
