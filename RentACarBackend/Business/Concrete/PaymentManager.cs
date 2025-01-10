using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        EfPaymentDal _paymentDal;

        public PaymentManager(EfPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        [ValidationAspect(typeof(PaymentValidation))]
        public IResult Add(Payment payment)
        {
            _paymentDal.Add(payment);
            return new SuccessResult(PaymentMessages.AddedSuccess);
        }

        public IResult Delete(Payment payment)
        {
            _paymentDal.Add(payment);
            return new SuccessResult(PaymentMessages.DeletedSuccess);
        }

        public IDataResult<List<Payment>> GetAll()
        {
            
            return new SuccessDataResult<List<Payment>>(PaymentMessages.ListedSuccess, _paymentDal.GetAll());
        }

        public IDataResult<Payment> GetById(int id)
        {
            return new SuccessDataResult<Payment>(PaymentMessages.GetByIdSuccess , _paymentDal.Get(p=>p.PaymentId==id));
        }

        [ValidationAspect (typeof(PaymentValidation))]
        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult(PaymentMessages.UpdatedSuccess);
        }
    }
}
