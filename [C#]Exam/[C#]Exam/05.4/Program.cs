using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            List<char> batman = new List<char>();
            char[] robin = new char[8];

            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                string arr = Convert.ToString(temp, 2).PadLeft(8, '0');

                for (int j = 0; j < arr.Length; j++)
                {
                    batman.Add(arr[j]);
                }
            }
            for (int i = 1; i < batman.Count; i+=step)
            {
                if (batman[i] == '1')
                {
                    batman[i] = '0';
                }
                if (batman[i] == '0')
                {
                    batman[i] = '1';
                }
            }
            for (int i = 0; i < batman.Count; i+=8)
            {
                for (int j = 0; j < 8; j++)
                {
                    robin[j] = batman[i + j];
                }
                string temp = new string(robin);
                int result = Convert.ToInt32(temp,2);
                Console.WriteLine(result);
            }
        }
    }
}
