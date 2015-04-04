using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSlum
{
    public class Injection : Bonus
    {
        public Injection(string id)
            : base(id, 200, 0, 0)
        {
            this.Countdown = 3;
            this.Timeout = 3;
        }
    }
}
