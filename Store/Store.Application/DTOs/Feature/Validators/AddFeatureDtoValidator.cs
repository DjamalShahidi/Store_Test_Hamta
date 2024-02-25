using FluentValidation;
using Store.Application.Contracts.Persistence;

namespace Store.Application.DTOs.Feature.Validators
{
    public class AddFeatureDtoValidator : AbstractValidator<AddFeatureDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddFeatureDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.Name)
                .NotNull().NotEmpty().WithMessage("{PropertyName} must be send")
                .MustAsync(async (name, token) =>
                 {
                     var isExist = await _unitOfWork.FeaturesRepository.IsExistWithName(name);
                     return !isExist;

                 }).WithMessage("feature with this title is exist");

            RuleFor(a => a.Value)
                .NotNull().NotEmpty().WithMessage("{PropertyName} must be send");

        }
    }
}
