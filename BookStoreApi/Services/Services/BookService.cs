using DataAccessor.Common;
using DataAccessor.UnitOfWork;
using Services.DeliveryFactories;
using Services.Dtos;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        private List<IDeliveryFactory> DeliveryFactories
            => new List<IDeliveryFactory> { new MotorbikeDeliveryFactory(), new AircraftDeliveryFactory(), new TrainDeliveryFactory() };
        public Deliver BuyBook(DeliveryInforDto deliveryInfor)
        {
            var factory = DeliveryFactories.FirstOrDefault(x=>x.ServiceType == deliveryInfor.ServiceType);
            if(factory == null)
            {
                throw new ArgumentNullException($"The service type: {deliveryInfor.ServiceType.ToString()} does not support");
            }
            var cost = _unitOfWork.VendorRepository.GetServiceCostByServiceType(deliveryInfor.ServiceType);
            var deliver = factory.GetDeliveryInfor(deliveryInfor.Book, cost);
            return deliver;
        }
    }
}
