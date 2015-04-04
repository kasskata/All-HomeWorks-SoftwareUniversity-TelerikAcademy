namespace TravelAgency
{
    using System;
    using System.Globalization;

    public abstract class Ticket : IComparable<Ticket>
    {
        public abstract string Type { get; }

        public virtual string From { get; set; }

        public virtual string To { get; set; }

        public virtual string Company { get; set; }

        public virtual DateTime DateAndTime { get; set; }

        public virtual decimal Price { get; set; }

        public virtual decimal SpecialPrice { get; set; }

        public abstract string Key { get; }

        public string FromToKey
        {
            get
            {
                return CreateFromToKey(this.From, this.To);
            }
        }

        public static string CreateFromToKey(string from, string to)
        {
            return from + "; " + to;
        }

        public static DateTime ParseDateTime(string dt)
        {
            var result = DateTime.ParseExact(dt, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
            return result;
        }

        public override string ToString()
        {
            var input = "[" + this.DateAndTime.ToString("dd.MM.yyyy HH:mm") + 
                "|" + this.Type.ToUpper() + 
                "|" + string.Format("{0:f2}", this.Price) + "]";

            return input;
        }

        public int CompareTo(Ticket otherTicket)
        {
            var compareTicket = this.DateAndTime.CompareTo(otherTicket.DateAndTime);
            
            if (compareTicket == 0)
            {
                compareTicket = string.Compare(this.Type, otherTicket.Type, StringComparison.Ordinal);
            }

            if (compareTicket == 0)
            {
                compareTicket = this.Price.CompareTo(otherTicket.Price);
            }

            return compareTicket;
        }
    }
}