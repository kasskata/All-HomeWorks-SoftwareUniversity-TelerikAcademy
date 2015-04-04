namespace TravelAgency
{
    public class AircraftTicket : Ticket
    {
        public AircraftTicket(string from, string to, string boatCompany, string dateTime, string price)
        {
            this.From = from;
            this.To = to;
            this.Company = boatCompany;
            var dateAndTime = ParseDateTime(dateTime);
            this.DateAndTime = dateAndTime;
            this.Price = decimal.Parse(price);
        }

        public override string Type
        {
            get
            {
                return "aircraft";
            }
        }

        public override string Key
        {
            get
            {
                return this.Type + ";;" + this.From + ";" + this.To + ";" + this.Company + this.DateAndTime + ";";
            }
        }
    }
}