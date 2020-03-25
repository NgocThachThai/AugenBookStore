using System;

namespace Services.Dtos
{
    public class AirCraftDeliver : Deliver
    {
        public string FlightNo { get; set; }
        public string GateArrival { get; set; }
        public DateTime DateArrival { get; set; }
    }
}
