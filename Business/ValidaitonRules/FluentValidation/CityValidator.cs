using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidaitonRules.FluentValidation
{
    public class CityValidator : AbstractValidator<Cities>
    {
        public CityValidator()
        {
            RuleFor(p => p.CityName).NotEmpty();
            RuleFor(p => p.CityName).MinimumLength(2);
        }
    }
}


