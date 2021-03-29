using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice >= 100);
            RuleFor(c => c.ModelYear).NotEmpty();
            //RuleFor(c => c.ModelYear).GreaterThan(2000);
            //RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(2000).When(c => c.BrandId == 1);

        }
    }
}


