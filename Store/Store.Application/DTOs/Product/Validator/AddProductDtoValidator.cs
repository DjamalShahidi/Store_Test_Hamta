﻿using FluentValidation;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.DTOs.Product.Validator
{
    public class AddProductDtoValidator : AbstractValidator<AddProductDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddProductDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            RuleFor(a => a.Title)
            .NotNull().NotEmpty().WithMessage("Title must be send");

            RuleFor(a => a.Code)
             .NotNull().NotEmpty().WithMessage("Code must be send");

            RuleFor(a => a.CategoryId)
                 .GreaterThan(0).WithMessage("Invalid CategoryId")
                 .MustAsync(async (id, token) =>
                 {
                     var isExist = await _unitOfWork.CategoryRepository.IsExist(id);
                     return isExist;

                 }).WithMessage("Invalid CategoryId");

            RuleFor(a => a.FeatureIds)
              .NotNull().NotEmpty().WithMessage("Invalid FeatureId")
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

                  return true;
              }).WithMessage("Invalid FeatureId");

        }
    }
}
