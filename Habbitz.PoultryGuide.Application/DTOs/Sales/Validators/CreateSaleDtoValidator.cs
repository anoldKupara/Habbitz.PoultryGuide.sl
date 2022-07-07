using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.DTOs.Sales.Validators
{
    public class CreateSaleDtoValidator : AbstractValidator<SaleDto>
    {
        public CreateSaleDtoValidator()
        {
            RuleFor(s => s.ItemPurchased)
               .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(s => s.Price)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .GreaterThan(0).WithMessage("{PropertyName} must be at least 1");

        }
    }
}
