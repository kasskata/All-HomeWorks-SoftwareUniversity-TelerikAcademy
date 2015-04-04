using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CustomLINQExtensionMethods
{
    public static class CustomLinqRequests
    {
        /// <summary>
        /// Maybe most stupid way to find "WhereNOT" method. Please feedback me 
        /// </summary>
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            IEnumerable<T> whereCollection = collection.Where<T>(predicate);
            List<T> whereNotCollection = new List<T>();
            foreach (var i in collection)
            {
                foreach (var y in whereCollection)
                {
                    if (!i.Equals(y))
                    {
                        whereNotCollection.Add(i);
                    }
                }
            }
            return whereNotCollection;
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            List<T> repeatedCountTimes = new List<T>();
            for (int i = 0; i < count; i++)
            {
                repeatedCountTimes.AddRange(collection);
            }
            return repeatedCountTimes;
        }
        public static IEnumerable<string> WhereEndsWith<String>(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            List<string> whereEndRequest = new List<string>();
            foreach (var i in collection)
            {
                foreach (var y in suffixes)
                {
                    if (i.Substring(i.Length - y.Length, y.Length) == y)
                    {
                        whereEndRequest.Add(i);
                    }
                }
            }
            return whereEndRequest;
        }
    }
}