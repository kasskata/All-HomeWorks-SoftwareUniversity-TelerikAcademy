namespace _03.StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public Student(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public delegate void ChangedProfile();

        public event ChangedProfile ChangeArgs;

        public byte Age { get; set; }

        public string Name { get; set; }

        //// Methods to warn your program for changes
        public void ChangeProfileName(string name)
        {
            if (this.Name != name)
            {
                this.OnChanged(name);
                this.Name = name;
            }
        }

        public void ChangeProfileAge(byte age)
        {
            if (this.Age != age)
            {
                this.OnChanged(age);
                this.Age = age;
            }
        }

        //// Official convension for events it will be like these two methods
        private void OnChanged(string name)
        {
            if (this.ChangeArgs != null)
            {
                this.ChangeArgs();
            }
            else
            {
                Console.WriteLine(string.Format("Property changed: Name (from {0} to {1})", this.Name, name));
            }
        }

        private void OnChanged(byte age)
        {
            if (this.ChangeArgs != null)
            {
                this.ChangeArgs();
            }
            else
            {
                Console.WriteLine(string.Format("Property changed: Age (from {0} to {1})", this.Age, age));
            }
        }
    }
}
