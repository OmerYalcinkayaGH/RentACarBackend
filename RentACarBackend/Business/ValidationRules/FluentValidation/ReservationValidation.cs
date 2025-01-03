using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ReservationValidation:AbstractValidator<Reservation>
    {
        public ReservationValidation()
        {
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.CarId).GreaterThanOrEqualTo(0);
            RuleFor(p => p.PickupBranchId).NotEmpty();
            RuleFor(p => p.PickupBranchId).GreaterThanOrEqualTo(0);
            RuleFor(p => p.ReturnBranchId ).NotEmpty();
            RuleFor(p => p.ReturnBranchId).GreaterThanOrEqualTo(0);
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.CarId).GreaterThanOrEqualTo(0);
            RuleFor(p=>p.StartDate).GreaterThanOrEqualTo(DateTime .Now);
            RuleFor(p => p.EndDate).GreaterThan(DateTime.Now);
            RuleFor(p => p.EndDate).GreaterThan (value=>value.StartDate);
            
        }
    }
}
