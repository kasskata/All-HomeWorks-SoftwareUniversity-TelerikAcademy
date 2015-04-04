
namespace _02.HumanWorkerStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class HumanWorkerStudent
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() { 
            new Student( "Pesho", "Iordanov", "12345"),
            new Student( "Mariika", "Iordanova", "12346"),
            new Student( "Svetlio", "nakov", "12356"),
            new Student( "Dancho", "Mihailov", "12387"),
            new Student( "Georgi", "stamatov", "01367"),
            new Student( "Popeye", "Atanasov", "12365"),
            new Student( "Mickey", "krasimirov", "12398"),
            new Student( "Todor", "Nikolov", "12307"),
            new Student( "Mihail", "Janson", "12323"),
            new Student( "Caspia", "Ben10", "12365")
            };
            var orderedAscendingStudents = students.OrderBy(st => st.FacuiltyNumber);

            List<Worker> workers = new List<Worker>() { 
            new Worker("Stancho", "Sokolov", 2723, 18),
            new Worker("Adriana", "najdenov", 142, 16),
            new Worker("Mariq", "Pejchewa", 152, 12),
            new Worker("Teodora", "Mihailova", 456 ,6),
            new Worker("Boshko", "stamatov", 676, 4),
            new Worker("ibn", "Alah", 566, 18),
            new Worker("Batman", "Robinov", 567, 20),
            new Worker("Kaloqn", "Karabov", 876, 19),
            new Worker("Altair", "IbnLahad", 2976, 15),
             new Worker("Kasandra", "Ajshetova", 22723, 13)
            };
            var orderedDescendingWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            //foreach (var student in orderedAscendingStudents)
            //{
            //     Console.WriteLine(student.FacuiltyNumber);
            //}

            //foreach (var worker in orderedDescendingWorkers)
            //{
            //    Console.WriteLine(string.Format("{0:0.000}",worker.MoneyPerHour()));
            //}

            List<Human> allPeople = new List<Human>();
            allPeople.AddRange(workers);
            allPeople.AddRange(students);

            var orderedPplByLastThenLastName = allPeople.OrderBy(x => x.FirstName).ThenBy(x=>x.LastName);

            foreach (var ppl in orderedPplByLastThenLastName)
            {
                Console.WriteLine(string.Format("{0}",ppl.FirstName +"|||"+ppl.LastName));
            }
        }
    }
}
