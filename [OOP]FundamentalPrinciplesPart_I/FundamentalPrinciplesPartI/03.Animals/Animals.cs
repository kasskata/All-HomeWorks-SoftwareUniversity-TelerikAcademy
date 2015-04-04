namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Animals : ISound
    {
        public Animals(string name, byte age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            Sex gender = sex;
            this.Sound = "";
        }

        public string Name { get; protected set; }

        public byte Age { get; protected set; }

        public String Sound { get; protected set; }

        public enum Sex
        {
            Male, Female
        }
        public override string ToString()
        {
            return string.Format("Name: \"{0}\" Age: \"{1}\" Sound: \"{2}\" ", this.Name, this.Age, this.Sound);
        }
    }
}
