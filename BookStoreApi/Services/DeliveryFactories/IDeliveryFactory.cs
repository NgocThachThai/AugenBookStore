using DataAccessor.Common;
using DataAccessor.Models;
using Services.Dtos;

namespace Services.DeliveryFactories
{
    public interface IDeliveryFactory
    {
        ServiceType ServiceType { get; }
        Deliver GetDeliveryInfor(Book book, double cost);
    }
}
