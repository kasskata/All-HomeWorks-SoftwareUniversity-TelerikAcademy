using GsmOperation.Call;
using GsmOperation.GsmCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GsmOperation.GsmCore
{
    public class GSMCoreInfo : Call.Call
    {

        private string model="";
        private string manufactorer="";
        private string price="";
        private string owner="";

        public static GSMCoreInfo IPhone
        {
            get
            {
                GSMCoreInfo IPhone = new GSMCoreInfo("4S", "IPhone");
                return IPhone;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty MODEL Value. Retry!");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public string Manufactorer
        {
            get
            {
                return this.manufactorer;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty MANUFACTORER Value. Retry!");
                }
                else
                {
                    this.manufactorer = value;
                }
            }
        }
        public string Price
        {
            get 
            {
                return this.price;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    this.price = "unvaliable";
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get 
            {
                return this.owner; 
            }
            set
            {
                this.owner = value;
            }
        }
        public Call.Call Call
        {
            get
            {
                Call.Call calling = new Call.Call();
                calling.CallTime = this.CallTime;
                calling.DialedNumber = this.DialedNumber;
                calling.DurationSec = this.DurationSec;
                return calling;
            }
        }
        public GSMCoreInfo(string model, string manufactorer)
        {
            this.Model = model;
            this.Manufactorer = manufactorer;
        }

        public override string ToString()
        {
            return "GSM : model-"+this.Model + " manufactory-" + this.Manufactorer+" owner-"+this.Owner+" price-"+this.Price;
        }

    }
}
