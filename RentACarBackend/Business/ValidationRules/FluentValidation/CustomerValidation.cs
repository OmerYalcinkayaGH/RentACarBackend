using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidation:AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(p=>p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MaximumLength(50);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Email).Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            RuleFor(p => p.PhoneNumber).Matches(@"^\+?[1-9]\d{1,3}[-.\s]?\(?\d{1,4}\)?[-.\s]?\d{1,4}[-.\s]?\d{1,9}$");
            RuleFor(p => p.CityId).NotEmpty();
            RuleFor(p => p.CountryId).NotEmpty();
            RuleFor(p => p.DriverLicenseNumber).NotEmpty();
            RuleFor(p => p.DriverLicenseNumber).Matches(@"^[A-Z0-9]{5,20}$");
            RuleFor(p => p.DateOfBirth).NotEmpty();
            RuleFor(p => p.DateOfBirth).Must(date => date <= DateTime.Now.AddYears(-18));
            

        }
    }
}
