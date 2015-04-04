namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher :Student, IPeople
    {
        public Teacher(string name,int uniCode)
            : base(name)
        {

        }
        
        public List<IDisciplines> setDiscipline { get; set; }
    }
}
