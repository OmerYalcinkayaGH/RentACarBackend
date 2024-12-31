using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPaymentMethodService
    {
        public IResult Add(PaymentMethod paymentMethod);
        public IDataResult<List<PaymentMethod>> GetAll();
        public IDataResult<PaymentMethod> GetById(int id);
        public IResult Update(PaymentMethod paymentMethod);
        public IResult Delete(PaymentMethod paymentMethod);
    }
}