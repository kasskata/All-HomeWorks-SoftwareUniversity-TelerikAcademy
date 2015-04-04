using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._2._3.StudentsSystem
{
    internal class Program
    {
        internal static void Main()
        {
            Student batman = new Student
                (
                "Batman","Petrov","Lazarov","0703429","GothamCity Ul.Vrajdebna Bl.Peshterata","0887-888-888","LoveRobin@maimunka.com","10",
                Student.UniversityList.UNSS,Student.FacultyList.Law,Student.SpecialtyList.Law
                );
            Student robin = (Student)batman.Clone();
            robin.FirstName = "Robin";
            Console.WriteLine(robin);
            Console.WriteLine(batman.Equals(robin));
            Console.WriteLine(robin.GetHashCode()+" "+batman.GetHashCode());
            if (batman != robin)
            {
                Console.WriteLine("its diffrent");
            }
            Console.WriteLine(batman.CompareTo(robin));

        }
    }
}
