namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class SchoolProjectTest
    {
        internal static void Main()
        {
            Student pesho = new Student("pesho",1245);
            Teacher pavlov = new Teacher("Pavlov",5432);
            pavlov.setDiscipline = new List<IDisciplines>();
            pesho.Comment = "kelemnce mako";
            Classes oop = new Classes("oop");
            oop.TeacherSet = new List<Teacher>();
        }
    }
}
