namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class Core
    {
        public static int[] ReadNumber(int start, int end)
        {
            try
            {
                if (start >= 100 || end >= 100)
                {
                    throw new ArgumentException();
                }
                int[] range = new int[end - start + 1];
                for (int i = 0; i < range.Length; i++)
                {
                    range[i] = start + i;
                }
                return range;
            }
            catch (ArgumentException msg)
            {
                Console.WriteLine("Invalid Number: " + msg.Message);
                throw new ArgumentException("");
            }
        }

        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Enter your range: ");
                Console.WriteLine(new string('=',42));
                Console.Write("Start = ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("End = ");
                int end = int.Parse(Console.ReadLine());
                var range = ReadNumber(start, end);
                int numberBefore = range[0];
                Console.WriteLine(new string('=', 42));

                Console.WriteLine("Enter 10 number between in range [{0}...{1}]",range[0],range[range.Length-1]);
                Console.WriteLine(new string('=', 42));

                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        int number = int.Parse(Console.ReadLine());
                        bool isOk = false;
                        if (number > numberBefore)
                        {
                            for (int j = 0; j < range.Length; j++)
                            {
                                if (number == range[j] && number < 100)
                                {
                                    isOk = true;
                                    range[j] = 0;
                                }
                            }
                            if (isOk != true)
                            {
                                i--;
                                throw new ArgumentException();
                            }
                            else
                            {
                                Console.WriteLine("Good! Continue {0} more...", 10 - i - 1);
                            }
                            numberBefore = number;
                        }
                        else
                        {
                            throw new ArgumentException("");
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("It's not a valid value.Try Again {0} more...", 10 - i - 1);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid value");
            }
        }
    }
}
