namespace AbStack
{
    using System;

    public class AbStack<T>
    {
        private const int InitialCapacity = 16;
        private int count;
        private T[] elements;

        public AbStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public int Capacity
        {
            get { return this.elements.Length; }
        }

        public void Push(T element)
        {
            this.Grow();
            this.elements[this.count] = element;

            this.count++;
        }

        public T Pop()
        {
            Srink();
            var element = this.elements[this.count];
            this.elements[this.count] = default(T);
            this.count--;

            return element;
        }

        public T[] ToArray()
        {
            return this.TrimExcess();

        }

        public T[] TrimExcess()
        {
            var trimmedCollection = new T[this.count];
            Array.ConstrainedCopy(this.elements, 0, trimmedCollection, 0, trimmedCollection.Length);

            return trimmedCollection;
        }

        private void Grow()
        {
            if (this.Count >= this.elements.Length - 1)
            {
                T[] newElementsArr = new T[this.elements.Length * 2];
                Array.ConstrainedCopy(this.elements, 0, newElementsArr, 0, this.elements.Length);
                this.elements = new T[newElementsArr.Length];
                this.elements = newElementsArr;
            }
        }
        private void Srink()
        {
            if (this.Count <= (this.elements.Length - 1) / 2 && this.Capacity > 16)
            {
                T[] newElementsArr = new T[this.elements.Length / 2];
                Array.ConstrainedCopy(this.elements, 0, newElementsArr, 0, newElementsArr.Length);
                this.elements = new T[newElementsArr.Length];
                this.elements = newElementsArr;
            }
        }

        public override string ToString()
        {
            var collectionToPrint = this.TrimExcess();

            return string.Format("{0}", string.Join(", ", collectionToPrint));
        }
    }
}
