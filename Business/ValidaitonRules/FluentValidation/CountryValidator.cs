using Entities.Concrete;
using FluentValidation;

namespace Business.ValidaitonRules.FluentValidation
{
    public class CountryValidator : AbstractValidator<Countries>
    {
        public CountryValidator()
        {
            RuleFor(p => p.CountryName).NotEmpty();
            RuleFor(p => p.CountryName).MinimumLength(2);
        }
    }
}
