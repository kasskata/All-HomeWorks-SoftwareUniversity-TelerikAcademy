namespace RestaurantManager.Models
{
    using Interfaces;

    public class Dessert : Meal, IDessert
    {
        public bool WithSugar { get; private set; }

        public Dessert(string name, decimal price, int calories, int quantity, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantity, timeToPrepare, isVegan)
        {
            this.WithSugar = true;
        }


        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}",
                this.WithSugar ? "" : "[NO SUGAR] ",
                base.ToString());
        }
    }
}
