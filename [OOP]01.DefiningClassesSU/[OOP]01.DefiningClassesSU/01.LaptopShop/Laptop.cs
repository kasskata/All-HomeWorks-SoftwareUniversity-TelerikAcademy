using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string cpu;
        private string gpu;
        private Battery battery;
        private decimal screenSize;
        private decimal price;

        public Laptop() { }
        public Laptop(string model, string manufacture, string cpu, string gpu, decimal screenSize)
        {
            this.model = model;
            this.manufacturer = manufacture;
            this.cpu = cpu;
            this.gpu = gpu;
            this.screenSize = screenSize;
        }

        public Laptop(string model, string manufacture, string cpu, string gpu, decimal screenSize, Battery battery, decimal price)
            : this(model, manufacture, cpu, gpu, screenSize)
        {
            this.battery = battery;
            this.price = price;

        }


        public string Manufacturer
        {
            get
            {
                if (this.manufacturer == "" || this.manufacturer == null)
                {
                    throw new ArgumentNullException("Not inserted value");
                }
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                if (this.model == "" || this.model == null)
                {
                    throw new ArgumentNullException("Not inserted value");
                }
                else return this.model;
            }
            private set
            {
                this.model = value;

            }
        }

        public string Cpu
        {
            get
            {
                if (this.cpu == "" || this.cpu == null)
                {
                    throw new ArgumentNullException("Not inserted value");
                }
                else return this.cpu;
            }
            private set
            {
                this.cpu = value;
            }
        }
        public string Gpu
        {
            get
            {
                if (this.gpu == "" || this.gpu == null)
                {
                    throw new ArgumentNullException("Not inserted value");
                }
                else return this.gpu;
            }
            private set
            {
                this.gpu = value;
            }
        }
        public Battery Battery
        {
            get
            {
                if (this.battery.BatteryLife == 0 || this.battery == null)
                {
                    throw new ArgumentNullException("Not inserted value");
                }
                else return this.battery;

            }
            private set
            {
                this.battery = value;
            }
        }
        public decimal ScreenSize
        {
            get
            {
                if (this.screenSize == 0 || this.screenSize == null)
                {
                    throw new ArgumentNullException("Not inserted value");
                }
                return this.screenSize;
            }
            private set
            {
                this.screenSize = value;
            }
        }
        public decimal Price
        {
            get
            {
                if (this.price == 0 || this.price == null)
                {
                    throw new ArgumentNullException("Not inserted value");
                }
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }
        public override string ToString()
        {
            return this.Manufacturer + "\n" +
                new string('=', 43) + "\n" +
                "Model: " + this.Model + "\n" +
                "CPU: " + this.Cpu + "\n" +
                "GPU: " + this.Gpu + "\n" +
                "Battery: " + this.Battery + "\n" +
                "Screen: " + this.ScreenSize + "\n" +
                "price: " + this.Price;
        }
    }
}