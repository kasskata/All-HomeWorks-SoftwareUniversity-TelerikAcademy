namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Cat : Animals
    {
        public Cat(string name, byte age, Sex sex)
            : base(name, age, sex)
        {

        }
    }
}
