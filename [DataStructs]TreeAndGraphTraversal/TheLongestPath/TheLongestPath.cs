// You are given a tree holding N nodes. Each node holds a unique number. Each node can have child nodes.
// Find the longest path by sum of the nodes from leaf to leaf.

namespace TheLongestPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TheLongestPath
    {
        static readonly Dictionary<int, List<int>> TreeNodes = new Dictionary<int, List<int>>();
        static readonly Dictionary<int, int?> Parents = new Dictionary<int, int?>();

        static void Main()
        {
            var edgesCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < edgesCount; i++)
            {
                var currentFriendship = Console.ReadLine();
                if (currentFriendship == null)
                {
                    continue;
                }
                var parent = int.Parse(currentFriendship.Split(' ')[0]);
                var child = int.Parse(currentFriendship.Split(' ')[1]);

                if (!TreeNodes.ContainsKey(parent))
                {
                    TreeNodes[parent] = new List<int>();
                }

                if (!TreeNodes.ContainsKey(child))
                {
                    TreeNodes[child] = new List<int>();
                }

                if (!Parents.ContainsKey(child))
                {
                    Parents[child] = parent;
                }

                if (!Parents.ContainsKey(parent))
                {
                    Parents[parent] = null;
                }

                TreeNodes[parent].Add(child);
                Parents[child] = parent;
            }

            var leaves = GetLeaves();
            var root = GetRoot();
            var pathsToRootList = new List<List<int>>();

            foreach (var leaf in leaves)
            {
                var cuurNode = leaf;
                var currentPathToRoot = new List<int>();
                while (cuurNode != root)
                {
                    currentPathToRoot.Add(cuurNode);
                    cuurNode = (int)Parents[cuurNode];
                }
                pathsToRootList.Add(currentPathToRoot);
            }

            var maximumPath = int.MinValue;

            for (var i = 0; i < pathsToRootList.Count; i++)
            {
                // My precious sexy linq ;)
                maximumPath = pathsToRootList
                    .Where((t, j) => i != j && !pathsToRootList[i].Intersect(t).Any())
                    .Select(t => pathsToRootList[i].Sum() + t.Sum() + root).Concat(new[]
                    {
                        maximumPath
                    })
                    .Max();
            }

            Console.WriteLine("\n" + maximumPath);
        }

        private static IEnumerable<int> GetLeaves()
        {
            var leaves = TreeNodes
                .Where(n => n.Value.Count == 0)
                .Select(n => n.Key)
                .ToList();
            return leaves;
        }

        private static int GetRoot()
        {
            var root = Parents.First(p => p.Value == null);
            return root.Key;
        }
    }
}
