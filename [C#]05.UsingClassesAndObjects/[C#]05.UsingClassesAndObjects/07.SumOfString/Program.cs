using System;
using System.Collections.Generic;

// * Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities)
//    Examples:
//    (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)  ~ 10.6
//    pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)  ~ 21.22
//    Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".

class Program
{
    static void Main()
    {
        string[] expression = "9 + 24 / ( 7 - 3 ) + 5 * 5".Split(' ');

        Stack<string> seqence = new Stack<string>();
        Queue<string> q = new Queue<string>();

        for (int i = 0; i < expression.Length; i++)
        {
            double number;
            bool ifNumber = double.TryParse(expression[i], out number);

            if (ifNumber)
            {
                q.Enqueue(expression[i]);
                ifNumber = false;
            }
            else
            {
                if (seqence.Count == 0)
                {
                    seqence.Push(expression[i]);
                }
                else if (
                         (seqence.Peek() == "+" || seqence.Peek() == "-") && 
                         (expression[i] == "+" || expression[i] == "-")
                        )
                {
                    seqence.Push(expression[i]);
                }
                else if (
                    (seqence.Peek() == "*" || seqence.Peek() == "/") && 
                    (expression[i] == "*" || expression[i] == "/"))
                {
                    seqence.Push(expression[i]);
                }
                else if ((seqence.Peek() == "*" || seqence.Peek() == "/") && 
                    (expression[i] == "+" || expression[i] == "-"))
                {
                    q.Enqueue(seqence.Pop());
                    seqence.Push(expression[i]);
                }
                else
                {
                    seqence.Push(expression[i]);
                }
            }
        }
        while (seqence.Count > 0)
        {
            if (seqence.Peek() == "(" || seqence.Peek() == ")")
            {
                seqence.Pop();
            }
            else
            {
                q.Enqueue(seqence.Pop());
            }
        }
        while (q.Count > 0)
        {
            if (q.Peek() != "+" && 
                q.Peek() != "-" && 
                q.Peek() != "*" && 
                q.Peek() != "/")
            {
                seqence.Push(q.Dequeue());
            }
            else
            {
                double firstNumber = 0;
                double secondNumber = 0;

                switch (q.Dequeue())
                {
                    case "+":
                        secondNumber = double.Parse(seqence.Pop());
                        firstNumber = double.Parse(seqence.Pop());
                        seqence.Push((firstNumber + secondNumber).ToString());
                        break;
                    case "-":
                        secondNumber = double.Parse(seqence.Pop());
                        firstNumber = double.Parse(seqence.Pop());
                        seqence.Push((firstNumber - secondNumber).ToString());
                        break;
                    case "*":
                        secondNumber = double.Parse(seqence.Pop());
                        firstNumber = double.Parse(seqence.Pop());
                        seqence.Push((firstNumber * secondNumber).ToString());
                        break;
                    case "/":
                        secondNumber = double.Parse(seqence.Pop());
                        firstNumber = double.Parse(seqence.Pop());
                        seqence.Push((firstNumber / secondNumber).ToString());
                        break;
                    default:
                        break;
                }
            }
        }
        Console.WriteLine("Result: "+ seqence.Peek());
    }
}