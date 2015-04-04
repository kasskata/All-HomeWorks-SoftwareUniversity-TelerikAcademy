namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Student : IPeople
    {
        public Student(string name)
        {
            this.Name = name;
        }

        public Student(string name,int uniCode)
        {
            this.Name = name;
            this.UNICode = uniCode;
        }
        public string Comment { get; set; }

        public string Name { get;private set; }

        public int UNICode { get;private set; }
    }
}
