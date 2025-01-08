using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Branch:IEntity
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string  Address { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int UserId { get; set; }
        public string PhoneNumber { get; set; }     


    }
}
