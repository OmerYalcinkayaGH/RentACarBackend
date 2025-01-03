using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ReservationSatutusValidation:AbstractValidator<ReservationStatu>
    {
        public ReservationSatutusValidation()
        {
                RuleFor (p=>p.ReservationStatuName ).NotEmpty();
            RuleFor(p => p.ReservationStatuName).MaximumLength(50);
        }
    }
}
