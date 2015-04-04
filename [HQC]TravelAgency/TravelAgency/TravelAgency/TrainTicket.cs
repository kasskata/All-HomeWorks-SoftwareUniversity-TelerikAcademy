namespace TravelAgency
{
    public class TrainTicket : Ticket
    {
        public TrainTicket(string from, string to, string dateTime, string price, string studentPrice)
        {
            this.From = from; 
            this.To = to;
            var dateAndTime = ParseDateTime(dateTime);
            this.DateAndTime = dateAndTime;
            this.Price = decimal.Parse(price);
            this.StudentPrice = decimal.Parse(studentPrice);
        }

        public TrainTicket(string from, string to, string dateTime)
        {
            this.From = from;
            this.To = to;
            this.DateAndTime = Ticket.ParseDateTime(dateTime);
        }

        public decimal StudentPrice { get; set; }

        public override string Type
        {
            get
            {
                return "Train";
            }
        }

        public override string Key
        {
            get
            {
                return this.Type + ";;" + this.From + ";" + this.To + ";" + this.DateAndTime + ";";
            }
        }
    }
}