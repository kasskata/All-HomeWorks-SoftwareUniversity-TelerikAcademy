using System.Globalization;
using System.Linq;
using System.Text;

namespace TravelAgency
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class TicketRepository : ITicketRepository
    {
        private readonly MultiDictionary<string, Ticket> ticketMultiDictionary = new MultiDictionary<string, Ticket>(true);

        private readonly Dictionary<string, Ticket> tickets = new Dictionary<string, Ticket>();

        ////OrderedMultiDictionary is the problem Bottle neck in 7th test! Dont have enough knowledge to fix it.
        /// Add method in OrderedMultiDictionary is too slow, but down want OrderedMultiDictionary.Range maybe can change with LINQ
        

        public int AirTicketsCount { get; set; }

        public int BusTicketsCount { get; set; }

        public int TrainTicketsCount { get; set; }

        public string AddAirTicket(string name, string from, string to, string airline, string datTime, string price)
        {
            var ticket = new AirTicket(name, from, to, airline, datTime, price);
            var result = this.AddTicket(ticket);
            if (result.Contains("created"))
            {
                this.AirTicketsCount++;
            }

            return result;
        }

        public string AddAirTicket(string name, string from, string to, string airline, DateTime dateTime, decimal price)
        {
            return this.AddAirTicket(name, from, to, airline, dateTime.ToString("dd.MM.yyyy HH:mm"), price.ToString());
        }

        public string DeleteAirTicket(string ticketToDelete)
        {
            var ticket = new AirTicket(ticketToDelete);
            var result = this.DeleteTicket(ticket);

            if (result.Contains("deleted"))
            {
                this.AirTicketsCount--;
            }

            return result;
        }

        public string FindTickets(string from, string to)
        {
            var fromToKey = Ticket.CreateFromToKey(from, to);
            if (!this.ticketMultiDictionary.ContainsKey(fromToKey))
            {
                return "No matches";
            }

            var ticketsFound = this.ticketMultiDictionary[fromToKey];

            var ticketsAsString = ReadTickets(ticketsFound);

            return ticketsAsString.ToLower();
        }

        public string FindTicketsInInterval(DateTime startDateTime, DateTime endDateTime)
        {
            var ticketsFound = this.ticketMultiDictionary.Values
                .Where(t => t.DateAndTime >= startDateTime && t.DateAndTime <= endDateTime).ToList();
            if (ticketsFound.Count == 0)
            {
                return "No matches";
            }
            
            var ticketsAsString = ReadTickets(ticketsFound);
            
            return ticketsAsString.ToLower();
        }

        public string AddTrainTicket(string from, string to, string dateTime, string price, string studentPrice)
        {
            var ticket = new TrainTicket(from, to, dateTime, price, studentPrice);
            var result = this.AddTicket(ticket);
            if (result.Contains("created"))
            {
                this.TrainTicketsCount++;
            }

            return result;
        }

        public string AddTrainTicket(string from, string to, DateTime dateTime, decimal price, decimal studentPrice)
        {
            return this.AddTrainTicket(
                from, 
                to, 
                dateTime.ToString("dd.MM.yyyy HH:mm"),
                price.ToString(),
                studentPrice.ToString());
        }

        public string DeleteTrainTicket(string from, string to, DateTime dateTime)
        {
            return this.DeleteTrainTicket(from, to, dateTime.ToString("dd.MM.yyyy HH:mm"));
        }

        public string AddBusTicket(string from, string to, string company, DateTime dateTime, decimal price)
        {
            return this.CreateBusTicket(from, to, company, dateTime.ToString("dd.MM.yyyy HH:mm"), price.ToString(CultureInfo.InvariantCulture));
        }

        public string DeleteBusTicket(string from, string to, string company, DateTime dateTime)
        {
            return this.DeleteBusTicket(from, to, company, dateTime.ToString("dd.MM.yyyy HH:mm"));
        }

        public int GetTicketsCount(TicketType type)
        {
            if (type == TicketType.Flight)
            {
                return this.AirTicketsCount;
            }

            if (type == TicketType.Bus)
            {
                return this.BusTicketsCount;
            }

            return this.TrainTicketsCount;
        }

        internal static string ReadTickets(ICollection<Ticket> tickets)
        {
            var sortedTickets = new List<Ticket>(tickets);
            sortedTickets.Sort();
            StringBuilder result = new StringBuilder();

            for (var i = 0; i < sortedTickets.Count; i++)
            {
                var ticket = sortedTickets[i];
                result.Append(ticket);

                if (i < sortedTickets.Count - 1)
                {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }
        
        internal string ExecuteCommand(string line)
        {
            if (line == string.Empty)
            {
                return null;
            }

            var firstSpaceIndex = line.IndexOf(' ');

            if (firstSpaceIndex == -1)
            {
                return "Invalid command!";
            }

            var command = line.Substring(0, firstSpaceIndex);
            var commandOutput = "Invalid command!";

            var allParameters = line.Substring(firstSpaceIndex + 1);
            var parameters = allParameters.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            for (var i = 0; i < parameters.Length; i++)
            {
                parameters[i] = parameters[i].Trim();
            }

            switch (command)
            {
                case "CreateFlight":
                    commandOutput = this.AddAirTicket(parameters[0], parameters[1], parameters[2], parameters[3], parameters[4], parameters[5]);
                    break;

                case "DeleteFlight":
                    commandOutput = this.DeleteAirTicket(parameters[0]);
                    break;

                case "CreateTrain":
                    commandOutput = this.AddTrainTicket(parameters[0], parameters[1], parameters[2], parameters[3], parameters[4]);
                    break;

                case "DeleteTrain":
                    commandOutput = this.DeleteTrainTicket(parameters[0], parameters[1], parameters[2]);
                    break;

                case "CreateBus":
                    commandOutput = this.CreateBusTicket(parameters[0], parameters[1], parameters[2], parameters[3], parameters[4]);
                    break;

                case "DeleteBus":
                    commandOutput = this.DeleteBusTicket(parameters[0], parameters[1], parameters[2], parameters[3]);
                    break;

                case "FindByDates":
                    commandOutput = this.FindTicketsInInterval(Ticket.ParseDateTime(parameters[0]), Ticket.ParseDateTime(parameters[1]));
                    break;

                case "FindTickets":
                    commandOutput = this.FindTickets(parameters[0], parameters[1]);
                    break;
            }

            return commandOutput;
        }

        protected string CreateBusTicket(string from, string to, string company, string dateTime, string price)
        {
            var ticket = new BusTicket(from, to, company, dateTime, price);
            var key = ticket.Key;
            string result;

            if (this.tickets.ContainsKey(key))
            {
                result = "Duplicated " + ticket.Type.ToLower();
            }
            else
            {
                this.tickets.Add(key, ticket);
                var fromToKey = ticket.FromToKey;
                this.ticketMultiDictionary.Add(fromToKey, ticket);
                result = ticket.Type + " created";
            }

            if (result.Contains("created"))
            {
                this.BusTicketsCount++;
            }

            return result;
        }

        private string AddTicket(Ticket ticket)
        {
            var key = ticket.Key;
            if (this.tickets.ContainsKey(key))
            {
                return "Duplicated " + ticket.Type.ToLower();
            }

            this.tickets.Add(key, ticket);
            var fromToKey = ticket.FromToKey;
            this.ticketMultiDictionary.Add(fromToKey, ticket);
            return ticket.Type + " created";
        }

        private string DeleteTicket(Ticket ticket)
        {
            var key = ticket.Key;
            if (!this.tickets.ContainsKey(key))
            {
                return ticket.Type + " does not exist";
            }

            ticket = this.tickets[key];
            this.tickets.Remove(key);
            var fromToKey = ticket.FromToKey;
            this.ticketMultiDictionary.Remove(fromToKey, ticket);
            return ticket.Type + " deleted";
        }

        private string DeleteTrainTicket(string from, string to, string dateTime)
        {
            var ticket = new TrainTicket(from, to, dateTime);
            var result = this.DeleteTicket(ticket);
            if (result.Contains("deleted"))
            {
                this.TrainTicketsCount--;
            }

            return result;
        }

        private string DeleteBusTicket(string from, string to, string company, string dateTime)
        {
            var ticket = new BusTicket(from, to, company, dateTime);
            var result = this.DeleteTicket(ticket);

            if (result.Contains("deleted"))
            {
                this.BusTicketsCount--;
            }

            return result;
        }
    }
}
