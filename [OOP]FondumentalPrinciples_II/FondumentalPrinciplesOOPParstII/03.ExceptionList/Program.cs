using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ExceptionList
{
    class InvalidRangeException
    {
         private const int MIN_INT_ = 1;
        private const int MAX_INT_ = 100;
        public DateTime MIN_DATETIME_ = DateTime.Parse("01/01/1980 00:00:00");
        public DateTime MAX_DATETIME_ = DateTime.Parse("01/31/2013 00:00:00");
 
        //blank constructor needed for an instance which would not output any unwanted error messages
        //this way we would be able to get the MIN AND MAX parameters of the instance without
        //getting any errors
        public InvalidRangeException(string blankconstructor)
        {
        }
        public InvalidRangeException()
        {
            string type = this.GetType().UnderlyingSystemType.ToString();
            string typeString = type.Substring(type.IndexOf('[') + 1, type.IndexOf(']') - type.IndexOf('[') - 1);
            if (typeString.Contains("Int"))
            {
                Console.WriteLine("Error: Invalid range.");
            }
            else if (typeString.Contains("DateTime"))
            {
                Console.WriteLine("Error: Invalid range. ");
            }
            else
            {
                Console.WriteLine("Error: Invalid range of the type or an unknown error");
            }
        }
        static void Main()
        {
        }
    }
}
