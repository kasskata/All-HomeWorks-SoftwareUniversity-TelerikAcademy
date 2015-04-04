namespace TravelAgency
{
    using System;

    public interface ITicketRepository
    {
        /// <summary>
        /// Add Air ticket to database
        /// </summary>
        /// <param name="name">Id of the plane</param>
        /// <param name="from">From where is coming</param>
        /// <param name="to">To wehre is comming</param>
        /// <param name="airline">Which Airline will come</param>
        /// <param name="dateTime">Date And time on come</param>
        /// <param name="price">Price of the ticket</param>
        /// <returns>Information if add is seccess</returns>
        string AddAirTicket(string name, string from, string to, string airline, DateTime dateTime, decimal price);

        string DeleteAirTicket(string flightNumber);

        string AddTrainTicket(string from, string to, DateTime dateTime, decimal price, decimal studentPrice);

        string DeleteTrainTicket(string from, string to, DateTime dateTime);

        string AddBusTicket(string from, string to, string company, DateTime dateTime, decimal price);

        /// <summary>
        /// Delete bus ticket from database
        /// </summary>
        /// <param name="from">From where is coming</param>
        /// <param name="to">To wehre is comming</param>
        /// <param name="company">Which company is Bus Provider</param>
        /// <param name="dateTime">Date and time of comming on station</param>
        /// <returns>Information if delete is seccess</returns>
        string DeleteBusTicket(string from, string to, string company, DateTime dateTime);

        /// <summary>
        /// Find ticket from database
        /// </summary>
        /// <param name="from">From where is coming</param>
        /// <param name="to">To wehre is comming</param>
        /// <returns>Information if find is seccess</returns>
        string FindTickets(string from, string to);

        string FindTicketsInInterval(DateTime startDateTime, DateTime endDateTime);

        int GetTicketsCount(TicketType type);
    }
}