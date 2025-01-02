using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BranchValidation:AbstractValidator<Branch>
    {
        BranchValidation() {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(50);
            RuleFor (p=>p.Address).NotEmpty();
            RuleFor(p => p.Address).Length(5,300);
            RuleFor(p=>p.CityId).NotEmpty();
            RuleFor(p=>p.PhoneNumber).NotEmpty();
            RuleFor(p => p.PhoneNumber).Matches(@"^\+?[1-9]\d{1,3}[-.\s]?\(?\d{1,4}\)?[-.\s]?\d{1,4}[-.\s]?\d{1,9}$");

            
        }
    }
}
