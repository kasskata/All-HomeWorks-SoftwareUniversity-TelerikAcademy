using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Person
    {
        private string name = "";
        private byte age = 0;
        private string email = "";

        public Person(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, byte age, string email)
            : this(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Mail = email;
        }
        public string Name
        {
            get
            {
                if (this.name == "")
                {
                    throw new ArgumentNullException("Name is requared field");
                }
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }
        public byte Age
        {
            get
            {
                if (this.age <= 0 || this.age >= 150)
                {
                    throw new ArgumentException("Invalid age insert! Please insert number[1...150]");
                }
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }
        public string Mail
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Contains("@"))
                    {
                        this.email = value;
                    }
                    else throw new ArgumentException("It's not a valid email!");
                }
            }
        }
        public override string ToString()
        {
            return "\nPerson \n" + new string('=', 43) + "\nName: " + this.Name + "\nAge: " + this.Age + "\nEmail: " + (string.IsNullOrEmpty(this.Mail) ? "None" : this.Mail);
        }
    }
}
