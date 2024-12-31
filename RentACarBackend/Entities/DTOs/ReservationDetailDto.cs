using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ReservationDetailDto:IDto
    {
        public int ReservationId { get; set; }
        public int CarId { get; set; }
        public int PickupBranchId { get; set; }
        public int ReturnBranchId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ReservationStatusName { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
