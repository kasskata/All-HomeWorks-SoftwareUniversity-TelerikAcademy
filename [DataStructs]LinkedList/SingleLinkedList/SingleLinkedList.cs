namespace SingleLinkedList
{
    using System;
    using System.CodeDom;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class SingleLinkedList<T> : IEnumerable<T>
    {
        private class ListNode<TNode>
        {
            protected bool Equals(ListNode<TNode> other)
            {
                return EqualityComparer<TNode>.Default.Equals(this.Value, other.Value) && Equals(this.Pointer, other.Pointer);
            }

            public ListNode(TNode value)
            {
                this.Value = value;
            }

            public TNode Value { get; set; }

            public ListNode<TNode> Pointer { get; set; }

            // Can't found other way to compare T and T... 
            public override bool Equals(object obj)
            {
                if ((obj as ListNode<T>).Value is String)
                {
                    return ((obj as ListNode<TNode>).Value as string) == (this.Value as string);
                }
                if ((obj as ListNode<T>).Value is int)
                {s
                    return ((obj as ListNode<TNode>).Value as int?) == (this.Value as int?);
                }
                return false;
            }
        }

        private ListNode<T> head;
        private ListNode<T> tail;
        private uint count;

        public uint Count
        {
            get { return this.count; }
        }

        public bool IsEmpty { get { return this.count == 0; } }

        public void Add(T value)
        {
            if (this.head == null)
            {
                this.head = new ListNode<T>(value)
                {
                    Pointer = this.tail
                };
            }
            else
            {
                var newElement = new ListNode<T>(value);

                if (this.tail == null)
                {
                    this.head.Pointer = newElement;
                    this.tail = newElement;
                }
                else
                {
                    this.tail.Pointer = newElement;
                    this.tail = newElement;
                }
            }

            this.count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                this.head = this.head.Pointer;
            }

            var node = this.head;
            var step = 0;

            while (node != null)
            {
                if (step == index - 1)
                {
                    if (count == index)
                    {
                        node.Pointer = null;
                        break;
                    }
                    node.Pointer = node.Pointer.Pointer;
                    this.count--;
                    break;
                }

                node = node.Pointer;
                step++;
            }

            this.count--;
        }

        public int FirstIndexOf(T element)
        {
            int index = 0;
            var node = this.head;
            ListNode<T> searchingNode = new ListNode<T>(element);
            while (node != null)
            {
                if (searchingNode.Equals(node))
                {
                    return index;
                }
                node = node.Pointer;
                index++;
            }

            return index = -1;
        }

        public int LastIndexOf(T element)
        {
            int index = 0;
            var ListOfIndexes = new List<int>(); 
            var node = this.head;
            ListNode<T> searchingNode = new ListNode<T>(element);
            while (node != null)
            {
                if (searchingNode.Equals(node))
                {
                    ListOfIndexes.Add(index);
                }
                node = node.Pointer;
                index++;
            }
            if (ListOfIndexes.Any())
            {
                return ListOfIndexes[ListOfIndexes.Count - 1];
            }

            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Pointer;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
