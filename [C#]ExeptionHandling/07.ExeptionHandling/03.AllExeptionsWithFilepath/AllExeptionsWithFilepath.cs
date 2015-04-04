using System;
using System.IO;
//Write a program that enters file name along with its full file path 
//(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
//Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.


class AllExeptionsWithFilepath
{
    static void Main()
    {
        try
        {
            //I changed only "Windows" on "Vindows".Have fun!
            string filePath = @"C:\VINDOWS\win.ini";
            Console.WriteLine(filePath);
            Console.WriteLine(File.ReadAllText(filePath));
//I have that File and exeptions appear if u dont have it and do it wrong things.try and it will catch all your misstakes
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("path is null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine(
                @"path is a zero-length string, contains only white space, or contains 
                  one or more invalid characters as defined by InvalidPathChars.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine(
@"he specified path, file name, or both exceed 
the system-defined maximum length. For example, 
on Windows-based platforms, paths must be less 
than 248 characters, and file names must be less 
than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine(
                @"path specified a file that is read-only.
-or-
This operation is not supported on the current platform.
-or-
path specified a directory.
-or-
The caller does not have the required permission.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("path is in an invalid format.");
        }
        catch (Exception)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
    }
}