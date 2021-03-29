using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.Company).NotEmpty();
            RuleFor(c => c.Company).MinimumLength(2);
        }
    }
}


