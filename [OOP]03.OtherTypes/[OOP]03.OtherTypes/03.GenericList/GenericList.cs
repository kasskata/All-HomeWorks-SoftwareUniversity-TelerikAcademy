namespace _03.GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;

    public class Version : Attribute
    {
        internal string name;
        public double version;

        public Version(string name)
        {
            this.name = name;
            version = 1.0;
        }
        public override string ToString()
        {
            return "\nAuthor: " + this.name + "\nVersion: " + this.version;
        }
    }
    [Version("Kaloqn Kasskata Anastasov",version=4.5)]
    public class GList<T> : IComparable<T>
    {
        private const int Size = 16;
        private T[] arr;
        private int currentIndex = 0;
        public GList()
        {
            this.arr = new T[Size];
        }
        public GList(int capacity)
        {
            this.arr = new T[capacity];
        }
        public int Lenght
        {
            get
            {
                return this.currentIndex;
            }
        }
        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        public static void Attributes(Type t)
        {
            Version MyAttribute =
           (Version)Attribute.GetCustomAttribute(t, typeof(Version));

            Console.WriteLine(MyAttribute.TypeId);
            Console.WriteLine(MyAttribute.version);
        }
        private T[] AutoSmall()
        {
            T[] newArr = new T[this.arr.Length / 2];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = this.arr[i];
            }
            return newArr;
        }
        private T[] AutoGrow()
        {
            T[] newArr = new T[this.arr.Length * 2];
            for (int i = 0; i < this.arr.Length; i++)
            {
                newArr[i] = this.arr[i];
            }
            return newArr;
        }

        public void Add(T a)
        {
            arr[this.currentIndex] = a;
            this.currentIndex++;
            if (currentIndex == arr.Length)
            {
                arr = AutoGrow();
            }
        }
        public void Remove(int index)
        {
            this.currentIndex--;
            if (this.currentIndex <= (arr.Length - 1) / 2)
            {
                arr = AutoSmall();
            }
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
        }

        public void Insert(T element, int index)
        {
            this.currentIndex++;
            if (currentIndex >= arr.Length)
            {
                arr = AutoGrow();
            }
            T item = this.arr[index];
            arr[index] = element;
            for (int i = index + 1; i < arr.Length; i++)
            {
                T currentItem = arr[i];
                arr[i] = item;
                item = currentItem;
            }
        }
        public void Clear()
        {
            currentIndex = 0;
            Array.Clear(this.arr, 0, arr.Length);
        }

        public int Find(T value)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public bool IsContain(T value)
        {
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(value))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public int CompareTo(T other)
        {
            return this.arr.Length;
        }

        public T Min()
        {
            Array.Sort(this.arr);
            return this.arr[0];
        }

        public T Max()
        {
            Array.Sort(this.arr);
            return this.arr[arr.Length - 1];
        }


        public override string ToString()
        {
            if (this.currentIndex > 0)
            {
                StringBuilder output = new StringBuilder();
                for (int i = 0; i < this.currentIndex; i++)
                {
                    output.Append(arr[i] + ",");
                }
                output.Remove(output.Length - 1, 1);
                var attributes = (Version[])typeof(GList<T>).GetCustomAttributes(typeof(Version), true);
                output.AppendLine(string.Format("\n{0}",new string('_',43)));
                output.AppendLine(attributes[0].ToString());
                output.AppendLine(string.Format("{0}", new string('_', 43)));
                return output.ToString();
            }
            else
            {
                return "Empty Generic List";
            }
        }
    }
}