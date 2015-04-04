namespace RestaurantManager.Interfaces
{
    using Models;

    public interface IMainCourse : IMeal
    {
        MainCourseType Type { get; }
    }
}