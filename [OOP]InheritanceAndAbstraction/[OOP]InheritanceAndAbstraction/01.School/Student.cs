namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Student : DetailsInfo, IHuman
    {
        private string name;
        public Student(string name, int uniqueClassNum)
        {
            this.Name = name;
            this.UniqueClassNumber=uniqueClassNum;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int UniqueClassNumber { get;private set; }

    }
}
