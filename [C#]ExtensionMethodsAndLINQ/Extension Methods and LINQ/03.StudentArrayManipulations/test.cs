namespace StudentArrayManipulations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using StudentArrayManipulations;


    class Test
    {
        public static void Print(IEnumerable<Student> list)
        {
            foreach (var student in list)
            {
                Console.WriteLine(student);
            }
        }
        // Write a method that from a given array of students finds all students whose first name is before its last 
        // name alphabetically. Use LINQ query operators.
        // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
       
        // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first 
        // name and last name in descending order. Rewrite the same with LINQ.

        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student {FirstName = "Abrahim", LastName="Nebestni", Age = 17},
                new Student {FirstName = "Mikelo",LastName = "Makiaveli" , Age = 30},
                new Student {FirstName = "Magelan",LastName = "Transotti" , Age = 20},
                new Student {FirstName = "Kurti", LastName="Kusrtev", Age = 23},
                new Student {FirstName = "Georgi",LastName = "Petrov" , Age = 24},
                new Student {FirstName = "Ivan",LastName = "Groznii" , Age = 18}
            };

            var linqSelection =
               from student in students
               where student.FirstName.CompareTo(student.LastName) < 0
               select new { FirstName = student.FirstName, LastName = student.LastName };

            Console.WriteLine("First name before last name lexicographicly: ");
            foreach (var student in linqSelection)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            Console.WriteLine("between 18 And 24 years old :");
            var between18And24 = students.Where(st => st.Age >= 18)
                .Where(st => st.Age <= 24);
            Print(between18And24);
            Console.WriteLine();

            //easear way - Lambda Expresions

            var sortByFirstThenLastDescendingWay = students.OrderByDescending(st => st.FirstName)
                .ThenBy(st => st.LastName);
            Console.WriteLine("Order By First Name Then Last Name Descending Way: ");
            Print(sortByFirstThenLastDescendingWay);

            //Hard Way - LINQ text
            // NotImplementedException
        
        
        
        }
    }
}
