// Write a program to read the tree from the console and find:
// The root node
// All leaf nodes (in increasing order)
// All middle nodes (in increasing order)
// * The longest path in the tree (the leftmost if several paths have the same longest length)
// * All paths in the tree with given sum P of their nodes (from the leftmost to the rightmost)
// ** All subtrees with given sum S of their nodes (from the leftmost to the rightmost)
namespace _01.PlayWithTrees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.DesignerServices;

    class Trees
    {
        public static Dictionary<int, Tree<int>> NodeByValue = new Dictionary<int, Tree<int>>();

        public static Tree<int> FindRootTree()
        {
            return NodeByValue.Values.FirstOrDefault(n => n.Parent == null);
        }

        public static List<Tree<int>> FindMiddleNodesList()
        {
            return NodeByValue.Values.Where(n => n.Children.Count > 0 && n.Parent != null).OrderBy(n => n.Value).ToList();
        }

        public static List<Tree<int>> FindLeafNodesList()
        {
            return NodeByValue.Values.Where(n => n.Children.Count == 0 && n.Parent != null).OrderBy(n => n.Value).ToList();
        }

        public static Tree<int> GetNodeByValue(int value)
        {
            if (!NodeByValue.ContainsKey(value))
            {
                NodeByValue[value] = new Tree<int>(value);
            }

            return NodeByValue[value];
        }

        static void Main()
        {
            int nodeCount = int.Parse(Console.ReadLine());
            for (int i = 1; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                int parentValue = int.Parse(edge[0]);
                Tree<int> parentNode = GetNodeByValue(parentValue);

                int childValue = int.Parse(edge[1]);
                Tree<int> childNode = GetNodeByValue(childValue);
                parentNode.Children.Add(childNode);
                childNode.Parent = parentNode;
            }
            int pathSum = int.Parse(Console.ReadLine());
            int subtreeSum = int.Parse(Console.ReadLine());
          
            var root = FindRootTree();

            Console.WriteLine("Full tree hierarchy from root");
            
            Console.WriteLine(new string('-',40));
            root.Print();

            Console.WriteLine(new string('-', 40));

            Console.WriteLine("Root: " + root.Value);

            var leafNodes = FindLeafNodesList();
            Console.WriteLine("Leaves: " + string.Join(", ", leafNodes));

            var middleNodes = FindMiddleNodesList();
            Console.WriteLine("Middle nodes: " + string.Join(", ", middleNodes));

            Console.WriteLine("Don't have time to implement other part from the problem.");
        }
    }
}