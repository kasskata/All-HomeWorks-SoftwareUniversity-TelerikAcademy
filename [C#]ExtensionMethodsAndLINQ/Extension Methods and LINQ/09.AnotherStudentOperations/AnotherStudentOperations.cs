namespace AnotherStudentOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class StudentBaseManipulated
    {
        public static List<Student> Students(this List<Student> student, string name, string lastName, string facultyNumber, string tel, string email, List<int> mark, GroupNumber group)
        {
            Student addingStudent = new Student { FirstName = name, LastName = lastName, FacultyNumber = facultyNumber, Tel = tel, Email = email, Mark = mark, Group = group };
            student.Add(addingStudent);
            return student;
        }
        public static IEnumerable<Student> OrderedByGroup(this List<Student> student)
        {
            return student.OrderBy(x => x.Group);
        }
    }

    public class AnotherStudentOperations
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student {
                    FirstName = "Abrahim",
                    LastName="Nebestni", 
                    FacultyNumber = "1012306", 
                    Tel = "0879000000" ,
                    Email = "AbrahimNebestni@abv.bg",
                    Mark = new List<int>{2,3,4,6,5,2,3,2,4,5,6},
                    Group = GroupNumber.Second},
                new Student {
                    FirstName = "Mikelo",
                    LastName = "Makiaveli" ,
                    FacultyNumber = "1012306" ,
                    Tel = "0877000001", 
                    Email = "MikeloMakiaveli@gmail.com",
                    Mark = new List<int>{2,3,4,5,2,3,4,4,4},
                    Group = GroupNumber.Forth},
                    new Student {
                    FirstName = "Magelan",
                    LastName = "Transotti" ,
                    FacultyNumber = "1012347",
                    Tel = "0878000002",
                    Email = "MagelanTransotti@abv.bg",
                    Mark = new List<int>{2,2,2,2,2,3,4,4,4},
                    Group = GroupNumber.First},
                new Student {FirstName = "Kurti",
                    LastName="Kurtev",
                    FacultyNumber = "1012348",
                    Tel = "0872000003", 
                    Email = "KurtiKurtev@yahoo.com",
                    Mark = new List<int>{2,2,2,2,2,3,4,4,4},
                Group = GroupNumber.Second},
                new Student {
                    FirstName = "Georgi",
                    LastName = "Petrov" ,
                    FacultyNumber = "1012349" ,
                    Tel = "0878000004", 
                    Email = "GeorgiPetrov@gmail.com",
                    Mark = new List<int>{2,2,2,2,2,3,4,4,4},
                Group = GroupNumber.Second},
                new Student {
                    FirstName = "Ivan",
                    LastName = "Groznii" , 
                    FacultyNumber = "0112350" ,
                    Tel = "102000005", 
                    Email = "vanko@split.com",
                    Mark = new List<int>{2,2,2,2,2,3,4,4,4},
                    Group = GroupNumber.First}
            };
            students.Students("Kote", "Maca", "1123456", "0878000011", "KoteMaca@gmail.com", new List<int> { 2, 3, 4, 5, }, GroupNumber.First);
            // check for email
            var studentsWithAbvEmail = students.Where(x => x.Email.IndexOf("@abv.bg") != -1);
            Console.WriteLine();
            //Student.Print(studentsWithAbvEmail);
            // check for Vivacom Phone becouse main is int and they are mobile
            var whichIsVivacomPhone = students.Where(x => x.Tel.IndexOf("0878", 0, 4) == 0);
            //Student.Print(whichIsVivacomPhone);

            var someoneWith6 = students.Select(st => new
            {
                Name = st.FirstName,
                badResult = st.Mark.IndexOf(6) != -1
            }).Where(st => st.badResult == true);

            //foreach (var student in someoneWith6)
            //{
            //    Console.WriteLine(student);
            //}

            var onlyTwo2 = students.Select(st => new
            {
                Name = st.FirstName,
                onlyTwo2 = st.Mark.IndexOf(2, 0, st.Mark.Count) == 2
            });

            //foreach (var student in onlyTwo2)
            //{
            //    Console.WriteLine(student);
            //}
            var selected = students.FindAll(x =>x.Mark.FindAll(y => y == 2).Count() == 2);

            //foreach (var student in selected)
            //{
            //    Console.WriteLine(student);
            //}

            var registredin2006 = students.Where(x => x.FacultyNumber[5]=='0').Where(x => x.FacultyNumber[6]=='6');

            //foreach (var student in registredin2006)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine();

            var orderByGroupName = students.OrderBy(x => x.Group);

            foreach (var student in orderByGroupName)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}