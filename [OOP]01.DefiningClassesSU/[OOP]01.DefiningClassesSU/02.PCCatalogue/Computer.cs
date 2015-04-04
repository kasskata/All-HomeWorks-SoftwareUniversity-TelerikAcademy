using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PCCatalogue
{
    public class Computer
    {
        private string name;
        private List<Component> severalComponents = new List<Component>();
        private decimal price = 0;

        public Computer(string name, Component component, decimal price)
        {
            this.Name = name;
            this.severalComponents.Add(component);
            this.Price = price;

        }

        public string Name
        {
            get
            {
                if (this.name == "" || this.name == null)
                {
                    throw new ArgumentNullException("Invalid value NAMEComputer");
                }
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public List<Component> SeveralComponents
        {
            get
            {
                if (this.severalComponents == null)
                {
                    throw new ArgumentException("Don't have any components.It's not a computer");
                }
                return this.severalComponents;
            }
            set
            {
                this.severalComponents = value;
            }
        }

        public decimal Price
        {
            get
            {
                if (this.price == 0)
                {
                    throw new ArgumentException("Don't have any components.It's not a computer");
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
            StringBuilder output = new StringBuilder(" PC: " + " Name: " + this.Name + "\n");
            decimal sum = 0;
            foreach (var component in this.severalComponents)
            {
                sum += component.Price;
                output.AppendLine(component.ToString());
            }
            this.Price = sum;
            output.AppendLine(string.Format(" Price: {0:C}", sum));
            return output.ToString();
        }
    }
}
