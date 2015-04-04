namespace _04.ElementBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Core
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAtribute("id","page");
            div.AddAtribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div*10);
        }
    }
}
