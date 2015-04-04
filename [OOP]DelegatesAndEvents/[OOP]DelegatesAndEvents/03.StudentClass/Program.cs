namespace _03.StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Student pesho = new Student("Pesho",24);
            pesho.ChangeProfileName("Mariika");
            pesho.ChangeProfileAge(18);

        }
    }
}
