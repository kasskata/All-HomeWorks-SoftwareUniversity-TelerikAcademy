using System;
using System.Text;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";

        string hell0World = string.Format("{0} {1}", hello, world);
        
        string helloWorld = hello + " " + world;
       
        string hello_World = string.Concat(hello +" "+ world);
       
        StringBuilder helloW0rld = new StringBuilder();
        helloW0rld.Append(hello);
        helloW0rld.Append(" ");
        helloW0rld.Append(world);
        helloW0rld.Append("!");
        
        //first variable
        Console.WriteLine(hell0World);
        //second variable
        Console.WriteLine(helloWorld);
        //thirth variable
        Console.WriteLine(hello_World);
        //Forth variable(StringBuilde funcionality)
        Console.WriteLine(helloW0rld);
    }
}