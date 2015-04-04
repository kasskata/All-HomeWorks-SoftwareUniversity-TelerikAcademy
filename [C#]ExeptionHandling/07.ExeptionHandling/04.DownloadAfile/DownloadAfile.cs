using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.


class DownloadAfile
{
    static void Main()
    {
        using (WebClient download = new WebClient())
        {
            try
            {
                download.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../AC.jpg");
                download.OpenRead("http://www.devbg.org/img/Logo-BASD.jpg");
            }
            catch (Exception Ex)
            {
                Console.WriteLine("invalid address!",Ex.Data);
            }
        }
    }
}
