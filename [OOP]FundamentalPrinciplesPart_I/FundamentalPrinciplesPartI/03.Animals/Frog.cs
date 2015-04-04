namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Frog : Animals
    {
        public Frog(string name, byte age, Sex sex)
            : base(name, age, sex)
        {
            this.Sound = "FrogSound...";
        }
    }
}
