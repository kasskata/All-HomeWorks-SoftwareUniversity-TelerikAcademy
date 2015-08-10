using System;
using System.Collections.Generic;

// Build a round dance, where everybody is holding a friend. 
// You are given the number the person who should lead the dance. 
// Every person has unique number. Every friendship is two-way. 
// If Stamat is a friend of Minka, Minka is a friend of Stamat. 
// There is no circular friendships (e.g. A-B, C-B and A-C).

namespace _02.JustDance
{
    class JustDance
    {
        static readonly Dictionary<int, List<int>> Graph = new Dictionary<int, List<int>>();

        private static readonly List<int> Visited = new List<int>();
        private static int length = 1;
        private static int maxLength;

        static void Main()
        {
            var numberOfFriendships = int.Parse(Console.ReadLine());
            var leadNumber = int.Parse(Console.ReadLine());

            for (var i = 0; i < numberOfFriendships; i++)
            {
                var currentFriendship = Console.ReadLine();

                if (currentFriendship == null)
                {
                    continue;
                }

                var edge = currentFriendship.Split(' ');
                var first = int.Parse(edge[0]);
                var second = int.Parse(edge[1]);

                if (!Graph.ContainsKey(first))
                {
                    Graph[first] = new List<int>();
                }
                if (!Graph.ContainsKey(second))
                {
                    Graph[second] = new List<int>();
                }

                Graph[first].Add(second);
                Graph[second].Add(first);
            }

            Dfs(leadNumber);

            Console.WriteLine(maxLength);
        }

        static void Dfs(int node)
        {
            if (Visited.Contains(node))
            {
                return;
            }

            Visited.Add(node);

            length++;
            if (length > maxLength)
            {
                maxLength = length;
            }

            foreach (var childNode in Graph[node])
            {
                Dfs(childNode);
            }

            length = 1;
        }
    }
}
