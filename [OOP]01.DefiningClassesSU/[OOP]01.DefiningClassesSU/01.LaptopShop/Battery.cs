using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.LaptopShop
{
    class Battery
    {
        private int batteryLife = 0;

        public Battery(int batteryLife)
        {
            this.batteryLife = batteryLife;
        }
        public int BatteryLife
        {
            get
            {
                if (this.batteryLife == 0)
                {
                    throw new ArgumentException("The battery is broken");
                }
                return this.batteryLife;
            }
            private set
            {
                this.BatteryLife = value;
            }
        }
        public override string ToString()
        {
            return this.BatteryLife.ToString()+"hours";
        }
    }
}
