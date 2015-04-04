namespace _03.Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Print(IEnumerable<Student> collection)
        {
            foreach (var student in collection)
            {
                Console.WriteLine(student);
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student pesho = new Student("Pesho", "Peshev", 18, "00823", "0878888888", "Pesho_picha@abv.bg", new List<double>() { 5, 3, 5, 6, 3, 2, 1, }, 1);
            Student gosho = new Student("Gosho", "Inkov", 31, "00814", "0978888888", "DeathHollow@gmail.com", new List<double>() { 5.6, 6, 6, 6, 6, 6, 6, }, 2);
            Student mariika = new Student("Mariika", "Inkova", 34, "00842", "0978883288", "Mariika_Izvratenata@gmail.com", new List<double>() { 3.6, 4, 2, 3.5, 3.5, 5, 2, }, 3);

            students.AddAll(pesho, gosho, mariika);

            //// 4. student From 2nd Group Ordered Ascending
            var studentFrom2ndGroupOrderedAscending = students.Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);

            // Print(studentFrom2ndGroupOrderedAscending);

            //// 5. Student By FirstName Then By Last Name
            var studentByFirstNameThenByLastName = students.Where(st => st.FirstName[0] > st.LastName[0]);

            // Print(studentByFirstNameThenByLastName);

            //// 6. studentByAge
            var studentsBetween18and24 = students.Where(st => st.Age >= 18 && st.Age <= 24).Select(st => new { FirstName = st.FirstName, LastName = st.LastName, Age = st.Age });

            // foreach (var student in  studentsBetween18and24)
            // {
            //     Console.WriteLine(student);
            // }

            //// 7. Sort Students
            var sortedByFirstThenByLAsName = students.OrderBy(st => st.FirstName).ThenBy(st => st.LastName);

            // Print(sortedByFirstThenByLAsName);

            //// 8. Filter Students by Email Domain
            var filterStudentsByEmailDomain = students.Where(st => st.Mail.Contains("@abv.bg"));

            // Print(filterStudentsByEmailDomain);

            //// 9. Filter Students by Phone

            var filterStudentsByPhone = students.Where(st => st.Phone.Contains("02")).Where(st => st.Phone.Contains("+3592")).Where(st => st.Phone.Contains("+359 2"));

            // Print(filterStudentsByPhone);

            //// 10. Excellent Students
            var excellentStudents = students.Where(st => st.Marks.Any(mark => mark == 6));

            //Print(excellentStudents);

            //// 11. Weak Students

            var weakStudents = students.Exactly(2,2);

            //Print(weakStudents);

            //// 12. Students Enrolled In 2014

            var studentsEnrolledIn2014 = students.Where(st => st.FacultyNumber[st.FacultyNumber.Length-2]=='1'&&
                st.FacultyNumber[st.FacultyNumber.Length - 1]=='4');

            Print(studentsEnrolledIn2014);
        }
    }
}
