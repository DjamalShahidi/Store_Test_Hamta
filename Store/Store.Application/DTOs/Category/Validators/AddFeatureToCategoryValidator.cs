using FluentValidation;
using Store.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.DTOs.Category.Validators
{
    internal class AddFeatureToCategoryValidator
    {
    }

    public class AddFeatureToCategoryDtoValidator : AbstractValidator<AddFeatureToCategoryDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddFeatureToCategoryDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.CategoryId)
            .GreaterThan(0).WithMessage("Invalid Id")
            .MustAsync(async (id, token) =>
            {
                var isExist = await _unitOfWork.CategoryRepository.IsExist(id);
                return isExist;

            }).WithMessage("category id not exist");

            RuleFor(a => a.FeatureIds)
           .NotNull().NotEmpty().WithMessage("FeatureIds is empty")
           .MustAsync(async (ids, token) =>
           {
               foreach (var id in ids)
               {
                   var isExist = await _unitOfWork.FeaturesRepository.IsExist(id);
                   if (!isExist)
                   {
                       return false;
                   }
               }

               return true; // All ids exist
           }).WithMessage("One or more feature ids do not exist");
        }
    }
}
