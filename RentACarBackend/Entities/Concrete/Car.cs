using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyPrice { get; set; }
        public short FuelTypeId{ get; set; }
        public short TransmissionTypeId { get; set; }
        public int Mileage { get; set; }
        public short  StatusId { get; set; }
        public int BranchId { get; set; }
    
    }
}
