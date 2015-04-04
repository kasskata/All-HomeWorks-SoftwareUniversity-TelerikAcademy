using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Person
{
    public class Person
    { 
        public Person()
        {
            this.Name = null;
            this.Age = null;

        }
        public Person(string name, byte age)
        :this()
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public byte? Age { get; set; }

        public override string ToString()
        {
            return this.Name +" " + (this.Age != null ? this.Age.ToString() : "no age");
        }
    }
}
