using Core.Entities;

namespace Entities.Concrete
{
    public class RentalRecord:IEntity
    {
        public int RentalId { get; set; }
        public int ReservationId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int KilometersDriven { get; set; }
        public string ConditionNotes { get; set; }
    }
}
