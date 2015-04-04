using System;
using System.Numerics;
using System.Text;

class Loop
{
    static void Main()
    {
        Console.WriteLine("Enter some BIIIIIIG Number(RAM hazard :P):");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        StringBuilder batman = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            batman.Append(" "+i);
        }
        Console.WriteLine(batman.ToString());
        //I tried 2197863251871623587261857628715687326587128723187285621672587326827364872364872634872364872354828576287 
        //and i have "Out of memory exception"
    }
}