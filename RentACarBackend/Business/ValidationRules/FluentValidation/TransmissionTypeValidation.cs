using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class TransmissionTypeValidation:AbstractValidator<TransmissionType>
    {
        public TransmissionTypeValidation()
        {
            RuleFor(p=>p.TransmissionTypeName).NotEmpty();
            RuleFor(p => p.TransmissionTypeName).MaximumLength(50);
        }
    }
}
