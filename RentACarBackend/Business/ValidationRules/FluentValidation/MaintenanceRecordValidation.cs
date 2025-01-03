using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MaintenanceRecordValidation:AbstractValidator<MaintenanceRecord>
    {
        public MaintenanceRecordValidation()
        {
            RuleFor(p=>p.CardId).NotEmpty();
            RuleFor(p => p.CardId).GreaterThanOrEqualTo(0);
            RuleFor(p => p.StartDate).NotEmpty();
            RuleFor (p=>p.EndDate ).NotEmpty();
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MaximumLength(500);
            RuleFor(p => p.Cost).NotEmpty();
            RuleFor(p => p.Cost).GreaterThanOrEqualTo(0);
        }
    }
}
