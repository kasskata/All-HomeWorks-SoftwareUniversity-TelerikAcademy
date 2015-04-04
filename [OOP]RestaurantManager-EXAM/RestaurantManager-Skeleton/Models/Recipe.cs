using System;
// ReSharper disable All

namespace RestaurantManager.Models
{
    using Interfaces;

    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        protected int calories;
        private MetricUnit unit;
        protected int timeToPrepare;
        private int quantityPerServing;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name");
                }
                name = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Price");
                }
                price = value;
            }
        }

        public int Calories
        {
            get { return calories; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Calories");
                }
                calories = value;
            }
        }

        public int QuantityPerServing
        {
            get { return quantityPerServing; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("quantity Per Serving");
                }
                quantityPerServing = value;
            }
        }

        public MetricUnit Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public int TimeToPrepare
        {
            get { return timeToPrepare; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Time to prepare");
                }
                timeToPrepare = value;
            }
        }

        public Recipe(string name, decimal price, int calories, int quantity, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantity;
            this.TimeToPrepare = timeToPrepare;
        }

        public override string ToString()
        {
            return  string.Format("==  {0} == ${1:0.00}\n" +
                    "Per serving: {2} {3}, {4} kcal\n" +
                    "Ready in {5} minutes",
                    this.Name,
                    this.Price,
                    this.QuantityPerServing,
                    this.Unit==MetricUnit.Grams?"g":"ml",
                    this.Calories,
                    this.timeToPrepare);
        }
    }
}
