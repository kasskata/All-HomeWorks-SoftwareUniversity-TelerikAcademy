using System;
//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the first two variables 
//(mind adding an interval). Declare a third string variable and initialize it with the value
//of the object variable (you should perform type casting).

class HelloWorld
{
    static void Main()
    {
        string Hello = "Hello";
        string World = "World";
        object HelloWorld = (Hello + " " + World);
        string TypeCasting =((string)HelloWorld);
        Console.WriteLine(HelloWorld);
    }
}