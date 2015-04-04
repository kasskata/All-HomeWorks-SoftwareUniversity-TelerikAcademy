namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : DetailsInfo, IHuman
    {
        public Teacher(string name , Discipline discipline)
        {
            this.Name = name;
            this.DisciplineSet = new List<Discipline>();
            this.DisciplineSet.Add(discipline);
        }
        public string Name { get; set; }

        public List<Discipline> DisciplineSet
        { get; set; }
    }
}
