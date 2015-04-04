namespace StudentsDb.DbContext
{
    using System.Data.Entity;
    using Models;

    public class StudentDataDbContext : DbContext
    {
        public StudentDataDbContext()
            : base("StudentData")
        {
        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Resource> Resourceses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

    }
}
