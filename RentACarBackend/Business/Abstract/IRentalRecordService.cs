using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalRecordService
    {
        public IResult Add(RentalRecord rentalRecord);
        public IResult Delete(RentalRecord rentalRecord);
        public IResult Update(RentalRecord rentalRecord);
        public IDataResult<List<RentalRecord>> GetAll();
        public IDataResult<RentalRecord> GetById(int id);

    }
}