using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GsmOperation.Call
{
    public class Call
    {
        public const decimal money = 0.37M;
        private string callTime;
        private string dialedNumber;
        private ulong durationSec;

        public string CallTime
        {
            get
            {
                return this.callTime;
            }
            set
            {
                this.callTime = value;
            }
        }
        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                this.dialedNumber = value;
            }
        }
        public ulong DurationSec
        {
            get
            {
                return this.durationSec;
            }
            set
            {
                this.durationSec = value;
            }
        }
        public override string ToString()
        {
            return "calls: Date/Time-" + this.CallTime + " Dialed Numbers-" + this.DialedNumber + " Duration(seconds)-" + this.DurationSec;
        }


        public void Delete(int index,List<Call> callPerGSM)
        {
            callPerGSM.Remove(callPerGSM[index]);
        }
        public void Add(int index, List<Call> callPerGSM)
        {
            callPerGSM.Add(callPerGSM[index]);
        }
        public void ClearAll(int index, List<Call> callPerGSM)
        {
            callPerGSM.Clear();
        }
    }
}
