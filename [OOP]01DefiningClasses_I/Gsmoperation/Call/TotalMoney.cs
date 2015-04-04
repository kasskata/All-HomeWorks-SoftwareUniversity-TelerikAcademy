using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GsmOperation.Call
{
    class TotalMoney
    {
        private const decimal money = 0.37M;

        public decimal SumAllCalls(List<Call> callPerGSM)
        {
            decimal totalMoney = 0;
            for (int i = 0; i < callPerGSM.Count; i++)
            {
                decimal perMinute = callPerGSM[i].DurationSec / 60;
                totalMoney += perMinute * money;
            }
            return totalMoney;
        }
    }
}
