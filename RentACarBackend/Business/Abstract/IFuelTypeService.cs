using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFuelTypeService
    {
        public IResult Add(FuelType fuelType);
        public IDataResult<List<FuelType>> GetAll();
        public IDataResult<FuelType> GetById(int id);
        public IResult Update(FuelType fuelType);
        public IResult Delete(FuelType fuelType);
    }
}