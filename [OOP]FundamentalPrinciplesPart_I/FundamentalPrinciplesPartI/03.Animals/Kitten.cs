namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Kitten :Cat
    {
        public Kitten(string name, byte age)
            :base(name,age,Sex.Female)
        {
            this.Sound = "Mrrr";
        }
    }
}
