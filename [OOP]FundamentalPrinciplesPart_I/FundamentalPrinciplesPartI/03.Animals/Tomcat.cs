namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Tomcat :Cat
    {
        public Tomcat(string name, byte age)
            :base(name,age,Sex.Male)
        {
            this.Sound = "Ouu Macoo";
        }
    }
}
