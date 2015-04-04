namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Classes
    {
        public Classes(string name)
        {
            this.Name = name;
            this.Comment = "";
        }

        public List<Teacher> TeacherSet { get; set; }
        
        public string Name { get; private set; }

        public string Comment { get; set; }
    }
}
