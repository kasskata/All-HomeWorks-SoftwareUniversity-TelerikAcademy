using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{

    public class MainCourse : Meal, IMainCourse
    {
        public MainCourseType Type { get; private set; }

        public MainCourse(string name, decimal price, int calories, int quantity, int timeToPrepare, bool isVegan, MainCourseType type)
            : base(name, price, calories, quantity, timeToPrepare, isVegan)
        {
            this.Type = type;
        }

        public override string ToString()
        {
            return string.Format("{0}\nType: {1}",base.ToString(),this.Type);
        }
    }
}
