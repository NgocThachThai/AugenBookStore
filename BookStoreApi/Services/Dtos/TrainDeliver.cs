using System;

namespace Services.Dtos
{
    public class TrainDeliver : Deliver
    {
        public string TrainNo { get; set; }
        public string StationArrival { get; set; }
        public DateTime DateArrival { get; set; }
    }
}
