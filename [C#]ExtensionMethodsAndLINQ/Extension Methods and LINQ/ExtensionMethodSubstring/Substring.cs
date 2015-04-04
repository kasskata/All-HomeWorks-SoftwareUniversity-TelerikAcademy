namespace ExtensionMethodSubstring
{
    using System;
    using System.Text;
    using ExtensionMethodSubstring;
    // Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
    // and has the same functionality as Substring in the class String.

    public static class SubstringOnStringbuilder
    {
        public static StringBuilder Substring(this StringBuilder text , int index, int length)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = index; i <= length; i++)
            {
                temp.Append(text[i]);
            }
            return temp;
        }
        static void Main()
        {
            StringBuilder text = new StringBuilder("Mada faka, kaka and Didie Drogba");
            var substring = text.Substring(0, 8);
            Console.WriteLine("!" + substring + "!");
        }
    }
}
