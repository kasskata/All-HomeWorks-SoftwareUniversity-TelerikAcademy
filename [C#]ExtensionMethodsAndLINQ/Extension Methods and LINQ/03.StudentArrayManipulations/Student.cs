namespace StudentArrayManipulations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    // Write a method that from a given array of students finds all students 
    // whose first name is before its last name lexicographycaly. Use LINQ query operators.


    public class Student
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return "Name: "+this.FirstName + " Last Name: " + this.LastName + " Age: " + this.Age + " ";
        }
    }
}
