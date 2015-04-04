namespace _1._2._3.StudentsSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : IComparable<Student>,ICloneable
    {
        public UniversityList university;
        public FacultyList faculty;
        public SpecialtyList specialty;

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermanentAdress { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }

        public enum UniversityList
        {
            SU, TU, NBU, UNSS
        }

        public enum FacultyList
        {
            Philosophy, Law, Mathematics, Phisics, Business, Management, Telecommunications
        }

        public enum SpecialtyList
        {
            Telecommunications, Marketing, Business, Entrepreneurship, Phisics, Mathematics, Informatics, Law, Philosophy
        }
        public UniversityList University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        public FacultyList Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }
        public SpecialtyList Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }
        public Student()
        {
        }

        public Student(string firstName,string middleName ,string LastName,string sSN)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = LastName;
            this.SSN = sSN;
        }
        public Student(string firstName, string middleName, string LastName, string SSN, string adres, string gSM, string email, string course, UniversityList uni, FacultyList faculty, SpecialtyList spec)
        :this(firstName,middleName,LastName,SSN)
        {
            this.PermanentAdress = adres;
            this.GSM = gSM;
            this.Course = course;
            this.University = uni;
            this.Faculty = faculty;
            this.Specialty = spec; ;
        }
        public override bool Equals(object secondSt)
        {
            var second = secondSt as Student;

            if (second == null)
            {
                return false;
            }
            if (!(Student.Equals(this.FirstName, second)))
            {
                return false;
            }
            if (this.SSN != second.SSN)
            {
                return false;
            }
            return true;
        }
        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }
        public static bool operator != (Student first, Student second)
        {
            return !Student.Equals(first, second);
        }
        public override string ToString()
        {
            return
                this.FirstName
                + " " + this.MiddleName
                + " " + this.LastName
                + " " + this.PermanentAdress
                + " " + this.SSN
                + " " + this.Course
                + " " + this.University
                + " " + this.Faculty
                + " " + this.Specialty;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public int CompareTo(Student secondSt)
        {
            if (this.FirstName != secondSt.FirstName)
            {
                return String.Compare(this.FirstName, secondSt.FirstName);
            }
            if (this.LastName != secondSt.LastName)
            {
                return String.Compare(this.LastName, secondSt.LastName);
            }
            if (this.SSN != secondSt.SSN)
            {
                return String.Compare(this.SSN, secondSt.SSN);
            }
            return 0;
        }

        public object Clone()
        {
            Student cloning = this.MemberwiseClone() as Student; //new Student(this.FirstName,this.MiddleName,this.LastName,this.SSN,this.PermanentAdress,this.GSM,this.Email,this.Course,this.University,this.Faculty,this.Specialty);
            return cloning;
        }
    }
}
