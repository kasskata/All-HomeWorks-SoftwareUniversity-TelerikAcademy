using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public abstract class Animal : ISound
    {
        public Animal(string name, byte age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name { get; private set; }

        public byte Age { get; private set; }

        public Gender Gender { get; private set; }

        public abstract void ProduceSound();
    }
}
