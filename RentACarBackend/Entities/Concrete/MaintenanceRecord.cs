using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{

    public class MaintenanceRecord:IEntity
    {
        public int MaintenanceId { get; set; }
        public int CardId { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }
 }

