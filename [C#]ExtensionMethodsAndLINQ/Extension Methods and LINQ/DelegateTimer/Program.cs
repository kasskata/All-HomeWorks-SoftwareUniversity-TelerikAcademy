//Using delegates write a class Timer that has can execute certain method at each t seconds.
// Read in MSDN about the keyword event in C# and how to publish events.
// Re-implement the above using .NET events and following the best practices
namespace DelegateTimer
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    class Timer
    {
        public event EventExample DoAction;
        public EventArgs even = null;

        public delegate void EventExample(Timer counter, EventArgs e);

        public void StartExample()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                if (DoAction != null)
                {
                    DoAction(this, even);
                }
            }
        }
    }


    class Subscriber
    {
        public void Subscribe(Timer example)
        {

            example.DoAction += new Timer.EventExample(DoStuff);
        }
        public void DoStuff(Timer timer, EventArgs e)
        {
            Console.WriteLine("I will display the current time every 2 seconds. Current time: " + DateTime.Now);
        }
    }

    class Test
    {
        static void Main()
        {
            Timer testTimer = new Timer();
            Subscriber testSubscriber = new Subscriber();

            testSubscriber.Subscribe(testTimer);
            testTimer.StartExample();
        }
    }
}