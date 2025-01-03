using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PaymentMethodValidation:AbstractValidator<PaymentMethod>
    {
        public PaymentMethodValidation()
        {
            RuleFor(p=>p.PaymentMethodName).NotEmpty();
            RuleFor(p => p.PaymentMethodName).MaximumLength(50);
        }
    }
}
