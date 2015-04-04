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

    public class Optimus<T> where T : struct
    {
        private T[] data;
        private int i;
        private string[] stringDublicate;
        private string[] ValueDublicate;
        
        public Optimus(int length)
        {
            if (length < 2)
            {
                throw new ArgumentException("The Array can't be less than 2 indexers !");
            }
            this.data = new T[length];
            this.i = data.Length / length-1;
        }



        public void Add(T value)
        {
            this.data[this.i] = value;
            this.i++;
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
                i = index;
                if (index > 0)
                {
                    this.i++;
                    return this.data[i - 1];
                }
                else
                {
                    return this.data[i];
                }
            }
        }

        public void Clear()
        {
            Array.Clear(this.data,0,this.data.Length);
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

    }
}
