namespace _03.Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public Student(string firstName, string lastName, byte age, string facultyNumber, string phone, string mail, List<double> marks, byte groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Mail = mail;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public List<double> Marks { get; set; }

        public byte GroupNumber { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(string.Format(
                "{0} {1}\n====================\nAge:{2} Faculty Number: {3} Group: {4}\nEmail: {5}\nMarks: ", this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.GroupNumber, this.Mail));
            output.Append(string.Join(", ", this.Marks));
            output.Append("\n");
            
            return output.ToString();
        }
    }
    public static class Extension
    {
        // Extend List<Student>.AddAll()
        public static List<Student> AddAll(this List<Student> collection, params Student[] all)
        {
            foreach (var item in all)
            {
                collection.Add(item);
            }
            return collection;
        }

        public static List<Student> Exactly(this List<Student> students, int howMany,byte marks)
        {
            List<Student> reqestResult = new List<Student>();
            byte count = 0;
            foreach (var st in students)
            {
                bool isOk = false;
                for (int i = 0; i < st.Marks.Count; i++)
                {
                    if (st.Marks[i] == marks)
                    {
                        count++;
                    }
                    if (count == howMany)
                    {
                        isOk = true;
                        break;
                    }
                }
                if (isOk == true)
                {
                    reqestResult.Add(st);
                }
            }
            return reqestResult;
        }
    }
}