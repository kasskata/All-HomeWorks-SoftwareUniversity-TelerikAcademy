namespace TravelAgency
{
    public class AirTicket : Ticket
    {
        public AirTicket(string name, string from, string to, string airline, string dateTime, string price)
        {
            this.Name = name;
            this.From = from;
            this.To = to;
            this.Company = airline;
            var dateAndTime = ParseDateTime(dateTime);
            this.DateAndTime = dateAndTime;
            this.Price = decimal.Parse(price);
        }

        public AirTicket(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string Type
        {
            get
            {
                return "Flight";
            }
        }

        public override string Key
        {
            get { return this.Type + ";;" + this.Name; }
        }
    }
}