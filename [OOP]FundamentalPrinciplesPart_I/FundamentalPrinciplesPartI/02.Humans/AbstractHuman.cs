namespace Humans
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class AbstractHuman 
    {
        public AbstractHuman(string name,string lastName)
        {
            this.FirstName = name;
            this.LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

    }
}
