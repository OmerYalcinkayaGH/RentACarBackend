using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentMethodManager : IPaymentMethodService
    {
        IPaymentMethodDal  _paymentMethodDal;

        public PaymentMethodManager(IPaymentMethodDal paymentMethodDal)
        {
            _paymentMethodDal = paymentMethodDal;
        }

        [ValidationAspect(typeof(PaymentMethodValidation))]
        public IResult Add(PaymentMethod paymentMethod)
        {
            _paymentMethodDal.Add(paymentMethod);
            return new SuccessResult(PaymentMethodMessages .AddedSuccess);
        }

        public IResult Delete(PaymentMethod paymentMethod)
        {
            _paymentMethodDal.Delete(paymentMethod);
            return new SuccessResult(PaymentMethodMessages.DeletedSuccess);
        }

        public IDataResult<List<PaymentMethod>> GetAll()
        {
            return new SuccessDataResult<List<PaymentMethod>>(PaymentMethodMessages.ListedSuccess, _paymentMethodDal.GetAll());

        }

        public IDataResult<PaymentMethod> GetById(int id)
        {
            return new SuccessDataResult<PaymentMethod>(PaymentMethodMessages.GetByIdSuccess,_paymentMethodDal.Get (p=>p.PaymentMethodId==id));
        }


        [ValidationAspect(typeof(PaymentValidation))]
        public IResult Update(PaymentMethod paymentMethod)
        {
            _paymentMethodDal.Update(paymentMethod);
            return new SuccessResult(PaymentMethodMessages.AddedSuccess);
        }
    }
}
