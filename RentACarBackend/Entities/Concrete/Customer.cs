using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {        
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int UserId { get; set; }
        public string DriverLicenseNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

}
