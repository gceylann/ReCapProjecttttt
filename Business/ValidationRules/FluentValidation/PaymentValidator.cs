﻿using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.NameSurname).NotEmpty();
            RuleFor(p => p.CardNo).NotEmpty();
            RuleFor(p => p.ExpirationDate).NotEmpty();
            RuleFor(p => p.Cvc).NotEmpty();
        }
    }
}
