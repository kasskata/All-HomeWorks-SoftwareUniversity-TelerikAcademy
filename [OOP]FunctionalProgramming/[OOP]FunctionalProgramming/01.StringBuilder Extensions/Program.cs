namespace _01.StringBuilder_Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            s.Append("kaji babe \"thank u.\"");
            Console.WriteLine(string.Format("Text: \n{0}",s));
            Console.WriteLine("Substring with parameters [1,6]: \n"+s.Substr(1, 6));
            Console.WriteLine("Remove text'babe':\n"+s.RemoveText("babe"));
            s.AppendAll(new List<string>{" Mai " , "uakahme ", "neshatata ", "Pesho!"});
            Console.WriteLine(s);
        }
    }
}
