using DataAccessor.Common;
using DataAccessor.Models;
using Services.Common;
using Services.Dtos;
using System;

namespace Services.DeliveryFactories
{
    public class TrainDeliveryFactory : IDeliveryFactory
    {
        public ServiceType ServiceType => ServiceType.Train;

        public Deliver GetDeliveryInfor(Book book, double cost)
        {
            return new TrainDeliver
            {
                Book = book,
                Cost = cost,
                DateArrival = DateTime.Now,
                StationArrival = StringExtenstion.RandomString(5),
                TrainNo = StringExtenstion.RandomString(5)
            };
        }
    }
}
