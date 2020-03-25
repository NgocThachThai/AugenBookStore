using System;

namespace Services.Dtos
{
    public class MotobikeDeliver : Deliver
    {
        public string DriveName { get; set; }
        public string MobilePhone { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
