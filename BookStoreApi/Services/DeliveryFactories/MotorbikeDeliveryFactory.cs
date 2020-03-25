using DataAccessor.Common;
using DataAccessor.Models;
using Services.Common;
using Services.Dtos;
using System;

namespace Services.DeliveryFactories
{
    public class MotorbikeDeliveryFactory : IDeliveryFactory
    {
        public ServiceType ServiceType => ServiceType.Motorbike;

        public Deliver GetDeliveryInfor(Book book, double cost)
        {
            return new MotobikeDeliver
            {
                Book = book,
                Cost = cost,
                MobilePhone = StringExtenstion.RandomString(5),
                DriveName = StringExtenstion.RandomString(5),
                DeliveryDate = DateTime.Now
            };
        }
    }
}
