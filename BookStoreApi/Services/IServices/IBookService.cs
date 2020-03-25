using Services.Dtos;

namespace Services.IServices
{
    public interface IBookService
    {
        Deliver BuyBook(DeliveryInforDto deliveryInfor);
    }
}
