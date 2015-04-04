using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.

class DeleteAllOddFiles
{
    static void Main()
    {
        string inputPah = @"bigFile.txt";
        string tempFile = Path.GetTempFileName();

        try
        {
            StreamReader input = new StreamReader(inputPah);
            using (input)
            {
                using (var output = new StreamWriter(tempFile))
                {
                    int number = 1;
                    string line;
                    while ((line = input.ReadLine()) != null)
                    {
                        if (number % 2 == 0)
                            output.WriteLine(line);
                        number++;
                    }
                }
            }
            File.Delete(inputPah);
            File.Move(tempFile, inputPah);
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }
}

