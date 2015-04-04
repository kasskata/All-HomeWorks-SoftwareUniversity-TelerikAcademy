using System;
using System.Diagnostics;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        Debug.Assert(grade < 0,"Grade cannot be less than zero");
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade cannot be less than zero");
        }

        Debug.Assert(minGrade < 0, "Minimum grade cannot be less than zero");
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("Minimum grade cannot be less than zero");
        }

        Debug.Assert(maxGrade <= minGrade, "Maximum grade cannot be less than Minimum grade");
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Maximum grade cannot be less than Minimum grade");
        }

        Debug.Assert(string.IsNullOrEmpty(comments),"The comments cannot be ");
        if (string.IsNullOrEmpty(comments))
        {
            throw new FormatException("The comments cannot be ");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
