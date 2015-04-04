namespace _01.School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class School
    {
        static void Main(string[] args)
        {
            Student pesho = new Student("Pesho",1234);
            Student mariika = new Student("Mariika",1235);
            mariika.Details = "Keep eyes on her, is very horny !";
            Discipline cSharp = new Discipline("C#",2,pesho,mariika);

            Teacher nakov = new Teacher("Svetlin Nakov",cSharp);
            Teacher vlado = new Teacher("Vlado Karamfilov", cSharp);

            Class firstLevel = new Class(nakov, "Level 2");

            IHuman[] allPeopleInSchool = new IHuman[] {  vlado, pesho, mariika, nakov};

            var sortedPpl = allPeopleInSchool.OrderBy(p => p.GetType() == typeof(Student)).ThenBy(p=>p.Name).ToList();
            
            //Console.WriteLine(mariika.Name +" Number "+ mariika.UniqueClassNumber +" Details: "+mariika.Details);
            foreach (var ppl in sortedPpl)
            {
                //Sorted By Teachers then Students
                Console.WriteLine(ppl.Name);
            }
            Console.WriteLine();
        }
    }
}
