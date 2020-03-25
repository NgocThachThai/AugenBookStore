using DataAccessor.Common;
using System;

namespace Services.Dtos
{
    public class AirCraftDeliver : Deliver
    {
        public string FlightNo { get; set; }
        public string GateArrival { get; set; }
        public DateTime DateArrival { get; set; }
        public override ServiceType ServiceType => ServiceType.Aircraft;

        public override string ServiceName => ServiceType.Aircraft.ToString();
    }
}
