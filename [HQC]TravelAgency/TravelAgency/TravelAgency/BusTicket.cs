namespace TravelAgency
{
    public class BusTicket : Ticket
    {
        public BusTicket(string from, string to, string company, string dateTime, string price)
        {
            this.From = from;
            this.To = to; 
            this.Company = company;
            var dateAndTime = ParseDateTime(dateTime);
            this.DateAndTime = dateAndTime;
            this.Price = decimal.Parse(price);
        }

        public BusTicket(string from, string to, string company, string dateTime)
        {
            this.From = from;
            this.To = to; 
            this.Company = company;
            var dateAndTime = ParseDateTime(dateTime);
            this.DateAndTime = dateAndTime;
        }

        public override string Type
        {
            get
            {
                return "Bus";
            }
        }

        public override string Key
        {
            get
            {
                return this.Type + ";;" + this.From + ";" + this.To + ";" +
                       this.Company + this.DateAndTime + ";";
            }
        }
    }
}
