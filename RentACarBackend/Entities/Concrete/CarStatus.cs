using Core.Entities;


namespace Entities.Concrete
{
    public class CarStatus:IEntity
    {        
        public short CarStatusId { get; set; }
        public string Status { get; set; }
    }     
}

