using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Salad : Meal, ISalad
    {
        public bool ContainsPasta { get; private set; }

        public Salad(string name, decimal price, int calories, int quantity, int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantity, timeToPrepare, true)
        {
            this.ContainsPasta = containsPasta;
        }

        public override string ToString()
        {
            return string.Format("{0}\nContains pasta: {1}",
                base.ToString(),
                this.ContainsPasta ? "yes" : "no");
        }
    }
}
