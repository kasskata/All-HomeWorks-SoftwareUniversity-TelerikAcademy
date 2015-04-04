using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HumanWorkerStudent
{
    public class Student : Human
    {
        public Student( string first, string last, string facultyNumber)
            : base(first, last)
        {
            this.FacuiltyNumber = facultyNumber;
        }

        public string FacuiltyNumber { get; private set; }
    }
}
