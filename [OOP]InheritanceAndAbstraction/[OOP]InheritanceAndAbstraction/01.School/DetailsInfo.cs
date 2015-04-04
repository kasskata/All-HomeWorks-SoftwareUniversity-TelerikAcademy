namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public abstract class DetailsInfo
    {
        public string details;
        public virtual string Details
        {
            get
            {
                if (this.details.Equals(string.Empty))
                {
                    return "Empty";
                }
                else
                {
                    return this.details;
                }
            }
            set
            {
                this.details = value;
            }
        }
    }
}
