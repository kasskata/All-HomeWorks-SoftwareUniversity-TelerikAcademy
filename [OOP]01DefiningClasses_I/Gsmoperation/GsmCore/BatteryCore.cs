using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GsmOperation.GsmCore
{
    public class BatteryCore
    {
        private string model;
        private uint hoursIdle;
        private byte hoursTalk;

        public string Model 
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
       
        public uint HoursIdle
        {
            get 
            {
                return this.hoursIdle;
            }
            set 
            {
                this.hoursIdle = value;
            }
        }

        public byte HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
        
        public enum Arhitecture
        {
            Li_Ion, NiMH, NiCd,
        }
        public BatteryCore(string model,uint hourseIdle,byte hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hourseIdle;
            this.HoursTalk = hoursTalk;
        }
        public override string ToString()
        {
            return "Battery specificaion: model-" + this.Model + " hoursidle-" + this.HoursIdle + " hours talk-" + this.HoursTalk;
        }
    }
}
