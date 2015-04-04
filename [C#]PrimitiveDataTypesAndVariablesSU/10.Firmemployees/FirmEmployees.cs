using System;

/*A marketing firm wants to keep record of its employees. 
Each record would have the following characteristics – first name, family name, age, gender (m or f),
ID number, unique employee number (27560000 to 27569999). 
Declare the variables needed to keep the information for 
a single employee using appropriate data types and descriptive names.*/

class FirmEmployees
    {
        static void Main()
        {
            string LastName = "Скучубрев";              //last name
            string FirstName = "Стамат";                //first name
            byte Age = 34;                              //age
            char Gender = 'm';                          //gender
            ulong IDNumber = 7810104012;                //ID number is ulong capable to carry 99.12.31.99.99 maximum amount on IDnumbers
            uint UniqueEmployeeNumber = 27748195;       //27560000 up to 27569999

            Console.WriteLine(
@"Name:{0}_{1}
Age:{2}
gender:{3}
ID:{4}
Employee ID (EID):{5}
", LastName, FirstName, Age, Gender, IDNumber, UniqueEmployeeNumber);
        }
    }