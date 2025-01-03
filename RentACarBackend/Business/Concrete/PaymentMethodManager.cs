using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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
        [ValidationAspect(typeof(PaymentMethodValidation))]
        public IResult Add(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PaymentMethod>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<PaymentMethod> GetById(int id)
        {
            throw new NotImplementedException();
        }


        [ValidationAspect(typeof(PaymentValidation))]
        public IResult Update(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
