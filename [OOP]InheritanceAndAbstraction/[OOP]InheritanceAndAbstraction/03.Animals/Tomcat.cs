using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public class Tomcat : Cat
    {
         public Tomcat(string name, byte age)
            : base(name, age, Gender.male)
        {

        }
    }
}
