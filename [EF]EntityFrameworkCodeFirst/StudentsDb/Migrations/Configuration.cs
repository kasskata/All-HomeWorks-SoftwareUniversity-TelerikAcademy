namespace StudentsDb.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using DbContext;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentDataDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentsDb.DbContext.StudentDataDbContext";

        }

        protected override void Seed(StudentDataDbContext context)
        {
            context.Students.Add(new Student
            {
                Name = "Kasskata",
                PhoneNumber = "0878999991",
                RegistrationDate = DateTime.Now,
                Birthday = DateTime.Now
            });
            context.Resourceses.Add(new Resource
            {
                TypeResourse = TypeResourse.Presentation,
                Link = "https://www.rejigitiqmaniaci.com/",
            });
            context.Courses.Add(new Course
            {
                Name = "C#DB",
                Description = "Loremi na maks",
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                Homeworks = new HashSet<Homework>
                {
                    new Homework
                    {
                       Content = "Ти сериозно ли мислиш, че SQL eзика е готин? Покажи на тия хора, как пишеш \u03BB Funcs",
                       CreateOn = DateTime.Now,
                       StudentId = 1,
                       TypeContent = TypeContent.Zip
                    },
                    new Homework
                    {
                        Content = "Ти сериозно ли мислиш, че SQL eзика е готин? Покажи на тия хора, как пишеш \u03BB Funcs",
                        CreateOn = DateTime.Now,
                        StudentId = 1,
                        TypeContent = TypeContent.Zip,
                    }
                }
            });
        }
    }
}
