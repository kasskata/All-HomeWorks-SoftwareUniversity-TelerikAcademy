namespace RestaurantManager.Interfaces
{
    using Models;

    public interface IRecipe
    {
        string Name { get; }

        decimal Price { get; }

        int Calories { get; }

        int QuantityPerServing { get; }

        MetricUnit Unit { get; }

        int TimeToPrepare { get; }
    }
}
