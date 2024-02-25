using AutoMapper;
using MediatR;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Category.Validators;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Responses;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Mediatr.Feature.Handlers.Commands
{
    public class AddFeatureToCategoryHandler : IRequestHandler<AddFeatureToCategory, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddFeatureToCategoryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Response> Handle(AddFeatureToCategory request, CancellationToken cancellationToken)
        {
            var validator = new AddFeatureToCategoryDtoValidator(_unitOfWork);
            var validatorResult = await validator.ValidateAsync(request.AddFeatureToCategoryDto);

            if (validatorResult.IsValid == false)
            {
                return new Response(validatorResult.Errors.Select(a => a.ErrorMessage));
            }

            var categoryId = request.AddFeatureToCategoryDto.CategoryId;

            var categoryFeatureis = new List<CategoryFeature>();

            foreach (var id in request.AddFeatureToCategoryDto.FeatureIds) {
                categoryFeatureis.Add(new CategoryFeature()
                {
                    CategoryId = categoryId,
                    FeatureId = id
                });
            }

            await _unitOfWork.CategoryFeatureRepository.AddListAsync(categoryFeatureis);

            await _unitOfWork.Save(cancellationToken);

            return new Response(null);
        }

    }
}
