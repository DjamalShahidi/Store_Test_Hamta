using FluentValidation;
using Store.Application.Contracts.Persistence;

namespace Store.Application.DTOs.Feature.Validators
{
    public class AddFeatureDtoValidator : AbstractValidator<AddFeatureDto>
    {
        //private readonly IFeaturesRepository _featuresRepository;

        public AddFeatureDtoValidator()
        {

            RuleFor(a => a.Name)
                .NotNull().NotEmpty().WithMessage("{PropertyName} must be send");

            RuleFor(a => a.Value)
                .NotNull().NotEmpty().WithMessage("{PropertyName} must be send");

        }
    }
}
