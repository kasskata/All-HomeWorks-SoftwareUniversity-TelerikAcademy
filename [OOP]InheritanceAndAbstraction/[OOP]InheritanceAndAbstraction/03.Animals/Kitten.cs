using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, byte age)
            : base(name, age, Gender.female)
        {

        }
    }
}
