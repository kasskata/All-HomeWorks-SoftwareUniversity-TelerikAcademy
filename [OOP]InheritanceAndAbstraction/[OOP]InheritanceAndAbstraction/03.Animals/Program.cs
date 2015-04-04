using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Cat("Mimi",4,Gender.female);
            Animal animal1 = new Dog("Sharo", 1, Gender.female);
            Animal animal2 = new Frog("Kikirica", 5, Gender.female);
            Animal animal3 = new Kitten("Mimi", 7);
            Animal animal4 = new Tomcat("Mimi", 5);
            Animal animal5 = new Frog("Mimi", 4, Gender.female);

            Animal[] zoo = new Animal[]{
            animal,animal1,animal2,animal3,animal4,animal
            };
            var avarageAge = zoo.Average(a=>a.Age);
            Console.WriteLine("{0:0.00}",avarageAge);
        }
    }
}
