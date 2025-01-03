using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PaymentValidation:AbstractValidator<Payment>
    {
        public PaymentValidation()
        {
            RuleFor(p=>p.ReservationId).NotEmpty();
            RuleFor(p => p.ReservationId).GreaterThanOrEqualTo(0);
            RuleFor (p=>p.Amount).NotEmpty();
            RuleFor (p=>p.PaymentDate).NotEmpty();
            RuleFor (p=>p.PaymentMethodId ).NotEmpty();
            RuleFor(p => p.PaymentMethodId).GreaterThanOrEqualTo(0);
            RuleFor(p=>p.TransactionId ).NotEmpty();           
            RuleFor(p => p.TransactionId).MaximumLength(50);
            RuleFor(p => p.TransactionId).Matches(@"^[a-zA-Z0-9-_]{16,50}$");
        }
    }
}
