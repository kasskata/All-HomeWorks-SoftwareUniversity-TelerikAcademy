namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Discipline : DetailsInfo
    {
        // private List<Student> strudents = new List<Student>();
        public Discipline(string name, int numberLectures, params Student[] students)
        {
            this.Name = name;
            this.NumberLectures = numberLectures;
            this.Students = new List<Student>();
            foreach (var student in students)
            {
                this.Students.Add(student);
            }
        }

        public string Name { get; set; }

        public int NumberLectures { get; set; }

        public List<Student> Students { get; set; }
    }
}
