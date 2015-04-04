using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LaptopShop
{
    class Program
    {
        static void Main()
        {
            Battery liIon = new Battery(24);
            Laptop asus = new Laptop("X", "Asus", "Intel", "AMD", 15.6M, liIon, 1450.99M);
            Console.WriteLine(asus);
            Console.WriteLine(asus.Battery.BatteryLife);
        }
    }
}
