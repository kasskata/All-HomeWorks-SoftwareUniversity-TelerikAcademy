using System;
using System.IO;
using System.Text.RegularExpressions;

//Modify the solution of the previous problem to replace only whole words (not substrings).
//the whole idea come by Jasson's pet.
//thank u dude
class RegularExpressions
{
    static void Main()
    {
        StreamReader input = new StreamReader("C#.txt");
        StreamWriter bigFile = new StreamWriter("bigFile.txt");
        string text = input.ReadToEnd();
        int count = 0;
        using (bigFile)
        {
            while (count != 96)
            //This is Madness !!
            {
                bigFile.WriteLine("{0}", text);
                count++;
            }
        }
        input.Close();
        StreamReader inputfinal = new StreamReader("bigFile.txt");
        StreamWriter output = new StreamWriter("bigFileStart.txt");

        for (string line; (line = inputfinal.ReadLine()) != null; )
        {
            output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
        }
    }
}
