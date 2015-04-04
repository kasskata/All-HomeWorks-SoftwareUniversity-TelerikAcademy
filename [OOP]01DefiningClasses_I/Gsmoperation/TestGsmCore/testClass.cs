
namespace GsmOperation.TestGsmCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using GsmOperation.GsmCore;

    public class testClass
    {
        public static void Test()
        {
            string[] models = { "xperia", "edge", "galaxy", "One", "Mother" };
            string[] manufactory = { "Sony", "HTC", "Samsung", "China","IPhone"};
            GSMCoreInfo[] batman = new GSMCoreInfo[5];
                for (int i = 0; i < 5; i++)
                {
                    batman[i] = new GSMCoreInfo(models[i], manufactory[i]);
                }
            for (int i = 0; i < batman.Length; i++)
            {
                Console.Write(batman[i].Manufactorer + " ");
                Console.WriteLine(batman[i].Model);
            }
            Console.WriteLine(GSMCoreInfo.IPhone.Manufactorer+" "+GSMCoreInfo.IPhone.Model);
        }
    }
}