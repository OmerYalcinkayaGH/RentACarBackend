using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarStatusService
    {
        public IResult Add(CarStatus carStatus);
        public IDataResult<List<CarStatus>> GetAll();
        public IDataResult<CarStatus> GetById(int id);
        public IResult Update(CarStatus carStatus);
        public IResult Delete(CarStatus carStatus);
    }
}
