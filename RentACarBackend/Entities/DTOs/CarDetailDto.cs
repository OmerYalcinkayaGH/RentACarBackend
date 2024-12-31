using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyPrice { get; set; }
        public string FuelTypeName { get; set; }
        public string TransmissionTypeName { get; set; }
        public int Mileage { get; set; }
        public string StatusName { get; set; }
        public string BranchName { get; set; }
    }
}
