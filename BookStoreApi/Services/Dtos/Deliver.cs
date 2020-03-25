using DataAccessor.Models;

namespace Services.Dtos
{
    public abstract class Deliver
    {
        public double Cost { get; set; }
        public Book Book { get; set; }
    }
}
