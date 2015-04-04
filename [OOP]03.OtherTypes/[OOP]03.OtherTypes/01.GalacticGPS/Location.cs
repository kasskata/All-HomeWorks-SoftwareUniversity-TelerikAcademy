namespace _01.GalacticGPS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum Planet
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }

    public struct Location
    {
        private double latitude, longitute;
        private Planet planet;
        public Location(double x, double y, Planet p)
        {
            this.latitude = x;
            this.longitute = y;
            this.planet = p;
        }
        public override string ToString()
        {
            return string.Format("{0},{1} - {2}",this.latitude,this.longitute,this.planet);
        }
    }
}
