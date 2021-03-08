using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<CarBrand>
    {
       public BrandValidator()
        {
            RuleFor(b => b.Brand).NotEmpty();  
            RuleFor(b => b.Brand).MinimumLength(2);
        }

    }

   
}
