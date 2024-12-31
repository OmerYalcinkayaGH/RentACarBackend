using Core.DataAccess.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFuelTypeDal:EntityRepositoryBase<FuelType,RentACarContext> { }
}
