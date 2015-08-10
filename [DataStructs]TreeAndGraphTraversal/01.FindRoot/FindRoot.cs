using System;
using System.Linq;

// You have a connected directed graph with N nodes and M edges. 
// You are given the directed edges from one node to another. 
// The nodes are numbered from 0 to N-1 inclusive. 
// Check whether the graph is a tree and find its root.

namespace _01.FindRoot
{
    class FindRoot
    {
        static void Main()
        {
            var numberOfEdges = int.Parse(Console.ReadLine());
            var hasParent = new bool[numberOfEdges];
            var hasChild = new bool[numberOfEdges];

            for (var i = 0; i < numberOfEdges; i++)
            {
                var currentLine = Console.ReadLine();
                if (currentLine == null)
                {
                    continue;
                }

                var child = int.Parse(currentLine.Split(' ')[1]);
                var parent = int.Parse(currentLine.Split(' ')[0]);
                hasParent[child] = true;
                hasChild[parent] = true;
            }

            var index = hasParent
                .Select((j, i) => new { i, j })
                .Where(c => c.j == false)
                .Select(c => c.i).FirstOrDefault();

            var hasNoParentCount = hasParent.Where(n => n == false).Count();

            if (hasNoParentCount == 1 && hasChild[index])
            {
                Console.WriteLine(index);
            }
            else if ((hasNoParentCount == 1 && hasChild[index] == false)
                || hasNoParentCount > 1)
            {
                Console.WriteLine("Forest is not a tree!");
            }
            else
            {
                Console.WriteLine("No root");
            }
        }
    }
}
