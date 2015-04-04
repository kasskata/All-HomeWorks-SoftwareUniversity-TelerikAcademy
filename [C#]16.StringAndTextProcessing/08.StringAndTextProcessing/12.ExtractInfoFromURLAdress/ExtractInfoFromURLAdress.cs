using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

//Write a program that parses an URL address given in the format
//and extracts from it the [protocol], [server] and [resource] elements. For example from the URL 
//http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

class ExtractInfoFromURLAdress
{
    static void Main()
    {
        string URL = "https://www.devsadasdawd-awdadskhdgasdkasdk-qweqwe-bg.org/fsador/um/index.php".ToLower();
       //find [protocol]
        int protocolEnd = URL.IndexOf(":");
        string protocol = URL.Substring(0, protocolEnd);
        Console.WriteLine("[protocol] = \"{0}\" ",protocol);
        //find [server]
        int serverStart = URL.IndexOf("www.");
        int serverEnd = URL.IndexOf('/',serverStart)-serverStart;
        string server = URL.Substring(serverStart, serverEnd);
        Console.WriteLine("[server] = \"{0}\" ",server);
        //find [resource]
        int resourceStart = URL.IndexOf('/', serverStart);
        string resource = URL.Substring(resourceStart);
        Console.WriteLine("[server] = \"{0}\" ", resource);
    }
}
