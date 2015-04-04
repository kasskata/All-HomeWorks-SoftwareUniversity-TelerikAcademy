using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSlum
{
    public class Pill : Bonus
    {
        public Pill(string id)
            : base(id, 0, 0, 100)
        {
            this.Countdown = 1;
            this.Timeout = 1;
        }
    }
}
