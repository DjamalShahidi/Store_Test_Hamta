using FluentValidation;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.DTOs.Category.Validators
{
    public class AddCategoryDtoValidator : AbstractValidator<AddCategoryDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddCategoryDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.Title)
            .NotNull().NotEmpty().WithMessage("{PropertyName} must be send")
            .MustAsync(async (title, token) =>
             {
                 var isExist = await _unitOfWork.CategoryRepository.IsExistWithThisTitle(title);
                 return !isExist;

             }).WithMessage("category with this title is exist");

        }
    }
}
