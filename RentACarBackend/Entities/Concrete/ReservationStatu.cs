using Core.Entities;

namespace Entities.Concrete
{
    public class ReservationStatu : IEntity
    {
        public short ReservationStatuId { get; set; }
        public string ReservationStatuName { get; set; }
    }
}
