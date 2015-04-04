namespace RestaurantManager.Models
{
    using Interfaces;

    public abstract class Meal : Recipe, IMeal
    {
        public bool IsVegan { get; private set; }

        protected Meal(string name, decimal price, int calories, int quantity, int timeToPrepare,bool isVegan) : base(name, price, calories, quantity, timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.Unit = MetricUnit.Grams;
        }

        public void ToggleVegan()
        {
            this.IsVegan = !this.IsVegan;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}",this.IsVegan?"[VEGAN] ":"",base.ToString());
        }
    }
}
