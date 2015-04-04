using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GsmOperation.GsmCore;
using GsmOperation.TestGsmCore;
using GsmOperation.Call;
public class Program
{
    static void Main()
    {
        string[] model = { "5S", "Galaxy", "Lumia 1080" };//necesery fields
        string[] manufactory = { "IPhone", "Samsung", "Nokia" };//necesery fields
        List<GSMCoreInfo> GSMs = new List<GSMCoreInfo>();
        //Loop for fill all fields
        for (int i = 0; i < model.Length; i++)
        {
            GSMCoreInfo GSM = new GSMCoreInfo(model[i], manufactory[i]);
            GSMs.Add(GSM);
            Console.WriteLine(GSM.ToString());
        }
        Console.WriteLine(GSMCoreInfo.IPhone);
        //Test the Call class
        List<Call> callPerPhone = new List<Call>();
        string[] callTime = { "2000.12.3;23:11", "2000.12.4;25:23", "2000.12.24;23:59", "2001.1.1;00:01" };
        string[] dialedNumber = { "0877123456", "0877123456", "0877123456", "0877123456" };
        ulong[] durationInSec = { 180, 240, 450, 360 };
        decimal sum = new decimal();
        for (int i = 0; i < 4; i++)
        {
            Call currentCall = new Call();
            currentCall.CallTime = callTime[i];
            currentCall.DialedNumber = dialedNumber[i];
            currentCall.DurationSec = durationInSec[i];
            Console.WriteLine(currentCall.ToString());
            callPerPhone.Add(currentCall);
        }
        //Idont have much time and i write it in Main to compile its prity good timing and fast rewriting
        TotalMoney total = new TotalMoney();
        Console.WriteLine("{0} \n Money spend: "+total.SumAllCalls(callPerPhone),GSMs[2]);
        ulong deffduration = callPerPhone[0].DurationSec;
        for (int i = 0; i <callPerPhone.Count; i++)
        {
            if (deffduration < callPerPhone[i].DurationSec)
            {
                deffduration = callPerPhone[i].DurationSec;
            }
        }
        for (int i = 0; i < callPerPhone.Count; i++)
        {
            if (deffduration == callPerPhone[i].DurationSec)
            {
                callPerPhone[i].DurationSec = 0;
            }
        }
        Console.WriteLine("{0} \n Money spend: " + total.SumAllCalls(callPerPhone), GSMs[2]);
        callPerPhone.Clear();
        Console.WriteLine("This Info is Cleared");
        Console.WriteLine("Have a nice Day");
    }
}
