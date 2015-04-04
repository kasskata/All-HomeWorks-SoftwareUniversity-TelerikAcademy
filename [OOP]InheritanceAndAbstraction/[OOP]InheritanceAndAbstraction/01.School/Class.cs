namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Class : DetailsInfo
    {
        public Class(Teacher teacher, string name)
        {
            this.Name = name;
            this.TeacherSet = new List<Teacher>();
            this.TeacherSet.Add(teacher);
        }

        public List<Teacher> TeacherSet { get; private set; }

        public string Name { get; private set; }

    }
}
