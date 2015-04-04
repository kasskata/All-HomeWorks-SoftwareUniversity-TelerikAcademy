using System;
//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, BIC code and 
//3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account 
//using the appropriate data types and descriptive names.

class BankAcount
    {
        static void Main()
        {
            string LastName="Savov";
            string FirstName = "Stamat";
            string MiddleName = "Naumov";
            decimal Balance = 213547.87642359989M;
            string BankName = "BNB";
            string IBAN = "BG00AAAA12345678901234";
            string BICCode = "E653";
            string CreditCardNo1 = "123456789012345";
            string CreditCardNo2 = "000000000000000";
            string CreditCardNo3 = "111111111111111";

            Console.WriteLine("{0}", LastName);
            Console.WriteLine("{0}", FirstName);
            Console.WriteLine("{0}", MiddleName);
            Console.WriteLine("{0}", Balance);
            Console.WriteLine("{0}", BankName);
            Console.WriteLine("{0}", IBAN);
            Console.WriteLine("{0}", BICCode);
            Console.WriteLine("{0}", CreditCardNo1);
            Console.WriteLine("{0}", CreditCardNo2);
            Console.WriteLine("{0}", CreditCardNo3);
        }
    }