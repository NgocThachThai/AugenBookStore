using DataAccessor.Common;
using DataAccessor.Models;
using Services.Common;
using Services.Dtos;
using System;

namespace Services.DeliveryFactories
{
    public class AircraftDeliveryFactory : IDeliveryFactory
    {
        public ServiceType ServiceType => ServiceType.Aircraft;

        public Deliver GetDeliveryInfor(Book book, double cost)
        {
            return new AirCraftDeliver
            {
                Book = book,
                Cost = cost,
                DateArrival = DateTime.Now,
                FlightNo = StringExtenstion.RandomString(5),
                GateArrival = StringExtenstion.RandomString(5)
            };
        }
    }
}
