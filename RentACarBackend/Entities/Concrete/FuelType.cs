using Core.Entities;

namespace Entities.Concrete
{
    public class FuelType:IEntity
    { 
        public short FuelTypeId { get; set;}
        public string FuelTypeName { get; set; }
    }
}
