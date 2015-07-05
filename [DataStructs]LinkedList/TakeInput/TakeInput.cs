namespace TakeInput
{
    using System;
    using System.Collections.Generic;

    public static class TakeInput
    {
        public static List<int> ListIntPrepare()
        {
            Console.WriteLine("Enter sequence. When you want to stop type \"e\"");
            string number = Console.ReadLine();
            List<int> listNumbers = new List<int>();

            while (number != "e")
            {
                listNumbers.Add(int.Parse(number));
                number = Console.ReadLine();

                if (string.IsNullOrEmpty(number))
                {
                    break;
                }
            }

            return listNumbers;
        }

        public static List<string> ListStringPrepare()
        {
            Console.WriteLine("Enter sequence. When you want to stop type \"e\"");
            string word = Console.ReadLine();
            List<string> listNumbers = new List<string>();

            while (word != "e")
            {
                listNumbers.Add(word);
                word = Console.ReadLine();

                if (string.IsNullOrEmpty(word))
                {
                    break;
                }
            }

            return listNumbers;
        } 
    }
}
