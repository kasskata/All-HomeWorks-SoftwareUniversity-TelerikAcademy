namespace ReversedList
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IReversedList<T> : IEnumerable<T>
    {
        T[] ReversedArray { get; set; }

        int Count { get; }
        
        int Capacity { get; }
        
        T this[int i] { get; set; }
        
        void Add(T element);
        
        void Remove(int index);
        
        string ToString();
    }

    public class ReversedList<T> : IReversedList<T>
    {
        private T[] reversedArray = new T[2];
        private int count;

        public ReversedList()
        {
        }

        public ReversedList(IList<T> collection)
        {
            this.CheckForIncrese(collection.Count);

            this.ReverseFill(collection);
        }

        public T[] ReversedArray
        {
            get { return this.reversedArray; }
            set { this.reversedArray = value.Reverse().ToArray(); }
        }

        public T this[int i]
        {
            get
            {
                return this.ReversedArray[i];
            }
            set
            {
                this.ReversedArray[i] = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.ReversedArray.Length;
            }
        }

        public void Add(T element)
        {
            this.CheckForIncrese(this.Count + 1);
            for (int i = this.Capacity - 1; i > 0; i--)
            {
                this.ReversedArray[i] = this.ReversedArray[i - 1];
            }
            this.ReversedArray[0] = element;
            this.count++;
        }
        public void Remove(int index)
        {
            for (; index < this.Count - 1; index++)
            {
                this.ReversedArray[index] = this.reversedArray[index + 1];
            }

            this.count--;

            CheckForDegrese();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var reveresedListToCount = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                reveresedListToCount[i] = this.reversedArray[i];
            }
            return ((IEnumerable<T>)reveresedListToCount).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void ReverseFill(IList<T> collection)
        {
            this.count = collection.Count;

            for (int i = 0, y = this.Count - 1; i < collection.Count; i++, y--)
            {
                this.ReversedArray[y] = collection[i];
            }
        }

        private void CheckForIncrese(int arrayCount)
        {
            if (arrayCount >= this.Capacity)
            {
                var copy = this.ReversedArray;
                this.ReversedArray = new T[arrayCount * 2];
                for (int i = 0; i < this.Count; i++)
                {
                    this.ReversedArray[i] = copy[i];
                }
            }
        }

        private void CheckForDegrese()
        {
            if (this.Count != 0)
            {
                if (this.Count != 1)
                {
                    if (this.Capacity/this.Count == 2)
                    {
                        var copy = this.ReversedArray;
                        this.ReversedArray = new T[this.Capacity/2];

                        for (int i = 0; i < this.Count; i++)
                        {
                            this.ReversedArray[i] = copy[i];
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < this.Count - 1; i++)
            {
                builder.AppendFormat("{0}, ", this.ReversedArray[i]);
            }

            if (this.Count > 0)
            {
                builder.AppendFormat("{0}", this.ReversedArray[this.Count - 1]);
            }
            else
            {
                builder.AppendFormat("(DEBUG MSG) The ReversedList is empty");
            }
            return builder.ToString();
        }
    }
}
