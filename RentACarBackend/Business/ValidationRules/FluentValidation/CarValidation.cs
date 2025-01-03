using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidation:AbstractValidator<Car>
    {
        public CarValidation()
        {
            RuleFor(p => p.LicensePlate).NotEmpty();
            RuleFor(p => p.LicensePlate).MaximumLength(20);
            RuleFor(p => p.Make).NotEmpty();
            RuleFor(p => p.Make).Length(2,50);
            RuleFor(p => p.Model).NotEmpty();
            RuleFor(p => p.Model).Length(2, 50);           
            RuleFor(p => p.Year).NotEmpty();           
            RuleFor(p => p.Year).InclusiveBetween(1900,DateTime.Now.Year);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.FuelTypeId).NotEmpty();
            RuleFor(p => p.TransmissionTypeId).NotEmpty();
            RuleFor(p => p.Mileage).NotEmpty();
            RuleFor(p => p.StatusId).NotEmpty();
            RuleFor(p => p.StatusId).Must(value => value >= 0);
            RuleFor(p => p.BranchId).NotEmpty();
            RuleFor(p => p.BranchId).GreaterThanOrEqualTo(0);


        }

      
    }
}
