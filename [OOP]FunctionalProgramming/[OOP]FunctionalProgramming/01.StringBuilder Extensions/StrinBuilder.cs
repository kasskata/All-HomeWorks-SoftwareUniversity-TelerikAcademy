using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilder_Extensions
{
    public static class StringBuilderExtensions
    {
        public static string Substr(this StringBuilder str, int startIndex, int length)
        {
            if (startIndex >= 0 && length <= str.Length)
            {
                return str.ToString().Substring(startIndex, length);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Start Index or Lenght inserted is no valid!");
            }
        }
        public static string RemoveText(this StringBuilder str, string text)
        {
            for (int i = 0; i < str.Length-text.Length; i++)
            {
                if (str.Substr(i,text.Length)==text)
                {
                    str.Remove(i, text.Length);
                }
            }
            return str.ToString();
        }

        public static string AppendAll<T>(this StringBuilder str, IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                str.Append(item);
            }
            return str.ToString();
        }
    }
}
