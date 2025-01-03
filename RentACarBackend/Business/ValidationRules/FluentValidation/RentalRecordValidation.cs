using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalRecordValidation:AbstractValidator<RentalRecord>
    {
        public RentalRecordValidation()
        {
            RuleFor(p=>p.ReservationId ).NotEmpty();
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(r => r.CarId).GreaterThanOrEqualTo(0);           
            RuleFor(p => p.CustomerId).NotEmpty();
            RuleFor(r => r.CustomerId).GreaterThanOrEqualTo(0);
            RuleFor(p => p.PickupDate).NotEmpty();
            RuleFor(p => p.PickupDate).LessThan(DateTime.Now);
            RuleFor(p => p.ReturnDate).NotEmpty();
            RuleFor(r => r.ReturnDate).GreaterThan(r => r.PickupDate);
            RuleFor(p => p.KilometersDriven).NotEmpty();
            RuleFor(r => r.KilometersDriven).GreaterThanOrEqualTo(0);
            RuleFor(p => p.ConditionNotes).MaximumLength(500);

        }
    }
}
