using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        public IResult Add(Payment payment);
        public IResult Delete(Payment payment);
        public IResult Update(Payment payment);
        public IDataResult<List<Payment>> GetAll();
        public IDataResult<Payment> GetById(int id);

    }
}