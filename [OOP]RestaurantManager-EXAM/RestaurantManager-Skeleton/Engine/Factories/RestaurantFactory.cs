namespace RestaurantManager.Engine.Factories
{
    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class RestaurantFactory : IRestaurantFactory
    {
        public IRestaurant CreateRestaurant(string name, string location)
        {
            return new Restaurants(name, location);
        }
    }
}
