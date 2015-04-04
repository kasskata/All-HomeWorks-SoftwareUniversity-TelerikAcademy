//Students: id, name, phone number, registration date, birthday

namespace StudentsDb.Models
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private ICollection<Course> courses; 

        public Student()
        {
            this.courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

    }
}
