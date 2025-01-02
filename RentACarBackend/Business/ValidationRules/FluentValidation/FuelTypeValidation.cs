using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class FuelTypeValidation:AbstractValidator<FuelType>
    {
        public FuelTypeValidation()
        {
            RuleFor(p=>p.FuelTypeName).NotEmpty();
            RuleFor(p => p.FuelTypeName).MaximumLength(50);
        }
    }
}
