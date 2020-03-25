using DataAccessor.Common;
using DataAccessor.Models;

namespace Services.Dtos
{
    public class DeliveryInforDto
    {
        public ServiceType ServiceType { get; set; }
        public Book Book { get; set; }
    }
}
