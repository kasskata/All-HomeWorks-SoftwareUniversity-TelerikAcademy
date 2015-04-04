namespace AnotherStudentOperations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    // FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. Create a List<Student> with sample students.
    public enum GroupNumber
    {
        First, Second, Thirth, Forth, Fiveth
    }
    //public enum Mark
    //{
    //   worse=1,Bad = 2,middle = 3;good=4,very_good =5,Excelent=6 
    //}



    public class Student 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<int> Mark { get; set; }
        public GroupNumber Group { get; set; }
        public string FacultyNumber { get; set; }
        public string Tel { get; set; }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Name: {0} {1}", this.FirstName, this.LastName);
            result.AppendLine();
            result.AppendLine("FN: " + this.FacultyNumber);
            result.AppendLine("Tel: " + this.Tel);
            result.AppendLine("Email: " + this.Email);
            result.AppendLine("Group:" + this.Group);
            // result.AppendLine("Marks:" + this.Mark);
            return result.ToString();
        }

        public static void Print(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}