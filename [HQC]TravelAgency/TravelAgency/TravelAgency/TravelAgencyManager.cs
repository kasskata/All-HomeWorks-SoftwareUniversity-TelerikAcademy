namespace TravelAgency
{
    using System;

    public class TravelAgencyManager
    {
        public static void Main()
        {
            var ticketRepository = new TicketRepository();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == null)
                {
                    break;
                }

                line = line.Trim();
                var commandResult = ticketRepository.ExecuteCommand(line);

                if (commandResult != null)
                {
                    Console.WriteLine(commandResult);
                }
            }
        }
    }
}