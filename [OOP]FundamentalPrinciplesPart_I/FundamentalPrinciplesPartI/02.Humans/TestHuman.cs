namespace Humans
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    internal class TestHuman
    {
        internal static void Print(IEnumerable<AbstractHuman> humans)
        {
            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }
        internal static void Main()
        {
            Console.WriteLine("           <<STUDENT OPERATIONS>>");
            //Students:
            List<Student> students = new List<Student>();
            string[] name = { "pesho", "gosho", "stamat", "haralampi", "Stoqn", "Murder", "Mulder", "Kosio", "Stefan", "Ivan" };
            string[] lastNames = { "Pavlov", "krumov", "urumov", "haralampiev", "ivanov", "pavlov", "stamatov", "kristiqnov", "bojev", "stupidov", };
            int[] grade = {1,3,6,5,1,7,3,9,11,7,};
            Random calc = new Random();
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student(name[i], lastNames[i],grade[i]));
            }
            //Printing Ordered by grade
            var orderByGrade = students.OrderBy(st => st.Grade);
           // Print(orderByGrade);

            Console.WriteLine("            <<WORKERS OPERATIONS>>");
            //Workers
            List<Worker> workers = new List<Worker>();
            string[] workerNames = { "pesho", "gosho", "stamat", "haralampi", "Stoqn", "Murder", "Mulder", "Kosio", "Stefan", "Ivan" };
            string[] workerLastNames = { "Pavlov", "krumov", "urumov", "haralampiev", "ivanov", "pavlov", "stamatov", "kristiqnov", "bojev", "stupidov", };
            int[] weekSalary = { 450,332,678,845,224,345,1234,375,567,356};
            int[] workHoursPerDay = { 5,6,7,8,9,10,12,10,5,8};
            for (int i = 0; i < 10; i++)
            {
                workers.Add(new Worker(workerNames[i], workerLastNames[i]));
                workers[i].WeekSalary = weekSalary[i];
                workers[i].WorkHoursPerDay=workHoursPerDay[i];
            }
            //Printing Ordered by payment
            var orderedByPayment = workers.OrderBy(st=> st.MoneyPerHour(st.WeekSalary,st.WorkHoursPerDay));
            Print(orderedByPayment);
        }
    }
}
