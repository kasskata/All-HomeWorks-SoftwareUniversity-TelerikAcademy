namespace RestaurantManager
{
    using System.Globalization;
    using System.Threading;
    using Engine;

    public class RestaurantManagementProgram
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            RestaurantManagerEngine.Instance.Start();
        }
    }
}