using Core.Entities;

namespace Entities.Concrete
{
    public class Reservation:IEntity
    {
        public int ReservationId { get; set; }
        public int CarId { get; set; }
        public int PickupBranchId { get; set; }
        public int ReturnBranchId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public short ReservationStatusId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
