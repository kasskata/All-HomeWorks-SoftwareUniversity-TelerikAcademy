namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Dog : Animals
    {
        public Dog(string name, byte age, Sex sex)
            : base(name, age, sex)
        {
            this.Sound = "Bauuuuu Maa";
        }
    }
}
