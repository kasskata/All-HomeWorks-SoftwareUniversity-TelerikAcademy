using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _02.AsynchronousTimer
{
    class Program
    {
        public static void Action(int ticks, int time)
        {
            for (int i = ticks; i >= 0; i--)
            {
                Thread.Sleep(time);
                Console.WriteLine(ticks--);
            }

        }
        static void Main(string[] args)
        {
            Thread timer = new Thread(() => 
            { 
                Action(200, 100); 
            });
            timer.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Parallel I write...");
                Thread.Sleep(800);
            }
        }
    }
}
