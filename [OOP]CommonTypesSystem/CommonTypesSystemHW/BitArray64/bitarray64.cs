//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private ulong bits;

        public BitArray64(ulong bits = 0)
        {
            this.bits = bits;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("invalid index");
                }

                return (bits & ((ulong)1 << index)) != 0 ? 1 : 0;
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("invalid index");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be 0 or 1.");
                }


                if (value == 1)
                {
                    this.bits = this.bits | ((ulong)1 << index);
                }
                else
                {
                    this.bits = this.bits & (~((ulong)1 << index));
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            BitArray64 arr = obj as BitArray64;
            if ((object)arr == null)
            {
                return false;
            }

            return this.bits == arr.bits;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first == second);
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                toString.AppendFormat("[{0}] = {1} \n", i, this[i]);
            }
            return toString.ToString();
            //return Convert.ToString((long)this.bits, 2).PadLeft(64, '0');
        }

        private class BitArray64Enumerator : IEnumerator
        {
            private int index = -1;
            private ulong bits;

            public BitArray64Enumerator(ulong bits)
            {
                this.bits = bits;
            }

            public object Current
            {
                get
                {
                    return (bits & ((ulong)1 << index)) != 0 ? 1 : 0;
                }
            }

            public bool MoveNext()
            {
                index++;
                return (index < 64);
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
