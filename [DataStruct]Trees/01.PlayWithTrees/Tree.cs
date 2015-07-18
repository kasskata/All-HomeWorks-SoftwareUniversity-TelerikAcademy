namespace _01.PlayWithTrees
{
    using System;
    using System.Collections.Generic;

    public class Tree<T>
    {
        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            foreach (var child in children)
            {
                this.Children.Add(child);
                child.Parent = this;
            }
        }

        public T Value { get; set; }

        public Tree<T> Parent { get; set; }

        public IList<Tree<T>> Children { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}", this.Value);
        }

        public void Print(int depth = 0)
        {
            Console.Write(new string(' ', 2 * depth));
            Console.WriteLine(this.Value);
            foreach (var child in this.Children)
            {
                child.Print(depth + 1);
            }
        }
    }
}
