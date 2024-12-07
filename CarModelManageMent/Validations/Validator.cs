using CarModelManageMent.Model;
using FluentValidation;

namespace CarModelManageMent.Validations
{
    public class Validator : AbstractValidator<CarModel>
    {
        public Validator()
        {
            RuleFor(c => c.Brand).NotEmpty();
            RuleFor(c => c.Class).NotEmpty();
            RuleFor(c => c.ModelName).NotEmpty();
            RuleFor(c => c.ModelCode).NotEmpty().Length(10);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Features).NotEmpty();
            RuleFor(c => c.Price).NotEmpty().GreaterThan(0);
            RuleFor(c => c.DateofManufacturing).NotEmpty();
        }
        
    }
}