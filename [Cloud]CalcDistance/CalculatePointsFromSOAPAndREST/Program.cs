using System;
using System.Net;
using CalculatePointsFromSOAPAndREST.WCFCalcDisstance;

namespace CalculatePointsFromSOAPAndREST
{
    class Program
    {
        static void Main()
        {
            using (var client = new WebClient())
            {
                var responseRESTfull = client.DownloadString("http://localhost:23216/api/Values?aX=2&aY=1&bX=54&bY=34");
                Console.WriteLine("REST Responce");
                Console.WriteLine(responseRESTfull);


                var responseSOAP = new CalcultorClient();
                var distance = responseSOAP.CalcDistance(new Point { X = 2, Y = 1 }, new Point { X = 54, Y = 34 });
                Console.WriteLine("SOAP Responce");
                Console.WriteLine(distance);
            }
        }
    }
}
