//Problem 5
//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, 
//inserting element at given position, clearing the list, finding element by its value and ToString(). 
//Check all input parameters to avoid accessing elements at invalid positions.

namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Optimus<T> 
    {
        private T[] data;
        private int index;
        private int length;

        public Optimus(int length)
        {
            this.length = length;
            if (length < 2)
            {
                throw new ArgumentException("The Array can't be less than 2 indexers !");
            }
            this.data = new T[length];
            this.index = data.Length / length - 1;
        }
        public void Add(T value)
        {
            Expand();
            this.data[this.index] = value;
            this.index++;
        }

        public T Insert(int i, T value)
        {
            return this.data[i] = value;
        }

        public T Remove(int index)
        {

            if (index < 0 || index > Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                this.index = index;
                if (index > 0)
                {
                    this.index++;
                    return this.data[index - 1];
                }
                else
                {
                    return this.data[index];
                }
            }
        }
        //public void Find(T value)
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        if (this.data[i] == value)
        //        {
        //            return data[i];
        //        }
        //    }
        //}
        public static void Find(string value)
        {
 
        }
        public void Clear()
        {
            Array.Clear(this.data, 0, this.data.Length);
            this.data = new T[this.length];
            this.index = data.Length / this.length - 1;
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }
        public T this[int index]
        {
            get 
            {
                if (index > data.Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.data[index];
            }
            set 
            {
                if (index > data.Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                this.data[index] = value;
            }
        }
        private void Expand()
        {
            T[] newData = new T[this.Capacity * 2];
            int index = new Int32();
            if (this.index >= this.data.Length)
            {
                for (index = 0; index < data.Length; index++)
                {
                    newData[index] = data[index];
                }
                this.data = newData;
                this.index = index;
            }
        }
        public T max()
        {
            Array.Sort(this.data);
            T max = this.data[this.data.Length - 1];
            return max;
        }
        public T Min()
        {
            Array.Sort(this.data);
            T max = this.data[0];
            return max;
        }
    }
}
