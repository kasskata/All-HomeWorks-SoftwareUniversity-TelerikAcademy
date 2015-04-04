namespace Humans
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : AbstractHuman
    {
        private int grade;
        public Student(string name,string lastName,int grade)
            :base(name,lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                if (this.grade <= 0 && this.grade >= 13)
                {
                    throw new ArgumentException("Invalid number of grade.Must be between 1 & 12");
                }
                else
                {
                    return this.grade;
                }
            }
            set
            {
                this.grade = value;
            }
        }
        public override string ToString()
        {
            return this.FirstName+" "+this.LastName+" "+this.Grade;
        }
        
    }
}
