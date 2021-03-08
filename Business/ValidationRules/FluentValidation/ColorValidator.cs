using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<CarColor>
    {
        public ColorValidator()
        {
            RuleFor(c => c.Color).NotEmpty();
            RuleFor(c => c.Color).MaximumLength(2);
        }
    }
}
