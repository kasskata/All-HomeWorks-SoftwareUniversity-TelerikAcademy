namespace StudentsDb
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using DbContext;
    using Migrations;
    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentDataDbContext, Configuration>());

            var db = new StudentDataDbContext();
            db.Students.Add(new Student
            {
                Name = "Bi0GaMe",
                PhoneNumber = "08812345678",
            });
            db.SaveChanges();

            StudentsHomework(db);
            CourseAndTheirResources(db);
            AddCourseWithHardCodeResources(db);
        }

        //          Adds a new course with some resources
        private static void AddCourseWithHardCodeResources(StudentDataDbContext db)
        {
            db.Courses.Add(new Course
            {
                Name = "Java Mava",
                Price = 100.00M,
                Resources = new HashSet<Resource>
                {
                    new Resource
                    {
                      TypeResourse  = TypeResourse.Document,
                      Link = "http://www.mahajseOtTukaJavaProstotii.bg"
                    },
                    new Resource
                    {
                        TypeResourse  = TypeResourse.Document,
                        Link = "http://www.mahajseOtTukaJavaProstotii.bg"
                    }
                }
            });
            db.SaveChanges();
        }

        //          List all course and their resources
        private static void CourseAndTheirResources(StudentDataDbContext db)
        {
            var courses = db.Courses;
            Console.WriteLine("List all course and their resources");
            foreach (var course in courses)
            {
                Console.WriteLine("Id: {0}\nName:{1}\nPrice:{2}\nStart: {3}\nEnd: {4}",
                    course.Id,
                    course.Name,
                    course.Price,
                    course.StartDate,
                    course.EndDate);
                foreach (var resourse in course.Resources)
                {
                    Console.WriteLine("Id: {0}\nLink{1}\nType Resourse:{2}",
                        resourse.Id,
                        resourse.Link,
                        resourse.TypeResourse);
                }
            }
            Console.WriteLine("End");
        }

        //          Lists all students and their homework submissions
        internal static void StudentsHomework(StudentDataDbContext db)
        {
            var students = db.Students;
            Console.WriteLine("Lists all students and their homework submissions");
            foreach (var student in students)
            {
                Console.WriteLine("Id: {0}\nName: {1}\nPhone: {2}\nRegisterOn: {3}\nBirthday:{4}",
                    student.Id,
                    student.Name,
                    student.PhoneNumber,
                    student.RegistrationDate,
                    student.Birthday);
                foreach (var course in student.Courses)
                {
                    foreach (var homework in course.Homeworks)
                    {
                        Console.WriteLine("Id: {0}\nContent: {1}\nTypeContent: {2}",
                            homework.Id,
                            homework.Content,
                            homework.TypeContent);
                    }
                }
            }
            Console.WriteLine("End\n");
        }
    }
}
