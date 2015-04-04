namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IDisciplines
    {
        string NameOfDiscipline { get; }
        int NumberOfLectures { get; }
        int NumberOfExercises { get; }
    }
}
