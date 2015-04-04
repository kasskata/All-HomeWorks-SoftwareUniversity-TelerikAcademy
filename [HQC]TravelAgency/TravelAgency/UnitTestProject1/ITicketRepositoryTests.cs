namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TravelAgency;

    [TestClass]
    public class ITicketRepositoryTests
    {
        [TestMethod]
        public void CreateBusTicketExpectNewTicket()
        {
            BusTicket ticketBus = new BusTicket("Pavlikeni", "Razgrad", "TransAll", "27.01.2015 21:20", "12.60");
            Assert.AreEqual("Pavlikeni", ticketBus.From);
            Assert.AreEqual("Razgrad", ticketBus.To);
            Assert.AreEqual("TransAll", ticketBus.Company);
            Assert.AreEqual(DateTime.Parse("27.01.2015 21:20"), ticketBus.DateAndTime);
            Assert.AreEqual((decimal)12.60, ticketBus.Price);
        }

        [TestMethod]
        public void CreateNewTicketsRepositoryOperationTestExpectRepository()
        {
            var repository = new TicketRepository();

            repository.AddAirTicket("AirBus", "NY", "NYC", "AirPesho", "27.01.2015 21:20", "120.60");
            repository.AddBusTicket("Pavlikeni", "Razgrad", "TransAll", DateTime.Parse("27.01.2015 21:20"), 12.60M);
            repository.AddTrainTicket("Pavlikeni", "Razgrad", "27.01.2015 21:20", "21.10", "12.60");

            Assert.IsNotNull(repository.TrainTicketsCount);
            Assert.IsNotNull(repository.AirTicketsCount);
            Assert.IsNotNull(repository.BusTicketsCount);

            repository.DeleteBusTicket("Pavlikeni", "Razgrad", "TransAll", DateTime.Parse("27.01.2015 21:20"));
            repository.DeleteTrainTicket("Pavlikeni", "Razgrad", DateTime.Parse("27.01.2015 21:20"));
            repository.DeleteAirTicket(repository.FindTickets("NY", "NYC"));

            Assert.AreEqual(0, repository.TrainTicketsCount);
            Assert.AreEqual(1, repository.AirTicketsCount);
            Assert.AreEqual(0, repository.BusTicketsCount);

            repository.FindTicketsInInterval(DateTime.Parse("25.01.2015 21:20"), DateTime.Parse("28.01.2015 21:20"));

            repository.AddAirTicket("AirBus", "NY", "NYC", "AirPesho", DateTime.Parse("27.01.2015 21:20"), 120.60M);
            repository.AddTrainTicket("Pavlikeni", "Razgrad", DateTime.Parse("27.01.2015 21:20"), 21.10M, 12.60M);

            repository.GetTicketsCount(TicketType.Bus);
            repository.GetTicketsCount(TicketType.Flight);
            repository.GetTicketsCount(TicketType.Train);
        }

        [TestMethod]
        public void CreateAicraftTicketExpectNewTicket()
        {
            AircraftTicket aircraftTicket = new AircraftTicket("Pavlikeni", "Razgrad", "TransAll", "27.01.2015 21:20", "12.60");
            
            Assert.AreEqual("Pavlikeni", aircraftTicket.From);
            Assert.AreEqual("Razgrad", aircraftTicket.To);
            Assert.AreEqual("TransAll", aircraftTicket.Company);
            Assert.AreEqual(DateTime.Parse("27.01.2015 21:20"), aircraftTicket.DateAndTime);
            Assert.AreEqual((decimal)12.60, aircraftTicket.Price);
            Assert.AreEqual("aircraft", aircraftTicket.Type);
        }
    }
}
