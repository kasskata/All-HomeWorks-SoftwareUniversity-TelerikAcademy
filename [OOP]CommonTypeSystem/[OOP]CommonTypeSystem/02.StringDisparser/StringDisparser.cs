namespace _02.StringDisparser
{
    using System;
    using System.Collections.Generic;

    public class StringDisparser : ICloneable, IEnumerable<char>, IComparable<StringDisparser>
    {
        public StringDisparser(params string[] output)
        {
            this.Output = string.Join(string.Empty, output);
        }

        public string Output { get; set; }

        public int Length 
        {
            get 
            { 
                return this.Output.Length; 
            } 

            private set 
            { 
            } 
        }

        public static bool operator ==(StringDisparser a, StringDisparser b)
        {
            return string.Equals(a, b);
        }

        public static bool operator !=(StringDisparser a, StringDisparser b)
        {
            return !string.Equals(a, b);
        }

        public int CompareTo(StringDisparser other)
        {
            return this.CompareTo(other);
        }

        public override string ToString()
        {
            return this.Output.ToString();
        }

        public override bool Equals(object obj)
        {
            StringDisparser other = obj as StringDisparser;
            return this.Output.Equals(other.Output);
        }

        public override int GetHashCode()
        {
            return this.Output.GetHashCode();
        }

        public object Clone()
        {
            return new StringDisparser()
            {
                Output = this.Output,
            };
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.Length; i++)
            {
                yield return this.Output[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
