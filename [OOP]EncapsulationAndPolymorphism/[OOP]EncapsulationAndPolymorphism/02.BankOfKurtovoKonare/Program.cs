using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>(){
               new IndividualAcc("petio", 123M, 12.3M, TypeAcc.Deposit),
               new CompanyAcc("Nakov", 12312335.231123M, 12.3M, TypeAcc.Mortgage),
               new IndividualAcc("Pesho",245M,12.3M,TypeAcc.Loan),
               new IndividualAcc("didko", 2312.50M, 10.3M, TypeAcc.Loan),
               new CompanyAcc("Pesho OOD", 123123.32M, 13.1M, TypeAcc.Mortgage)
            };

            foreach (Account acc in accounts)
            {
                Console.WriteLine(acc.InterestOnPeriod(13));
            }
        }
    }
}
