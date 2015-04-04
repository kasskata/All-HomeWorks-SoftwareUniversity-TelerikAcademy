using System;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    using Interfaces;

    public class Drink : Recipe, IDrink
    {
        public new int Calories
        {
            get { return this.calories; }
            set
            {
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("Calories dor Drink");
                }
                this.calories = value;
            }
        }

        public new int TimeToPrepare
        {
            get { return this.TimeToPrepare; }
            set
            {
                if (value > 20)
                {
                    throw new ArgumentOutOfRangeException("Time to prepare for Drink");
                }
                this.timeToPrepare = value;
            }
        }

        public Drink(string name, decimal price, int calories, int quantity, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantity, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
            this.Unit = MetricUnit.Milliliters;
        }

        public bool IsCarbonated { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}\nCarbonated: {1}", base.ToString(),this.IsCarbonated?"yes":"no");
        }
    }
}
