using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class CountTheBrackets
{
    static void Main()
    {
        int count = 0;
        string equation = ")(a+b))";
        for (int i = 0; i < equation.Length; i++)
        {
            if (equation[i].Equals('('))
            {
                count++;
            }
            if (equation[i].Equals(')'))
            {
                count--;
            }
        }
        Console.Write(equation +"  ==>  ");
        if (count < 0 || count > 0)
        {
            Console.WriteLine("Wrong brackets");
        }
        else
        {
            Console.WriteLine("Right brackets");
        }

    }
}
