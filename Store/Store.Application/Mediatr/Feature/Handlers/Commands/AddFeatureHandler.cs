﻿using AutoMapper;
using MediatR;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Feature;
using Store.Application.DTOs.Feature.Validators;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Responses;
using Store.Domain;

namespace Store.Application.Mediatr.Feature.Handlers.Commands
{
    public class AddFeatureHandler : IRequestHandler<AddFeature, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddFeatureHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Response> Handle(AddFeature request, CancellationToken cancellationToken)
        {
            var validator = new AddFeatureDtoValidator(_unitOfWork);
            var validatorResult = await validator.ValidateAsync(request.Request);

            if (validatorResult.IsValid == false)
            {
                return new Response(validatorResult.Errors.Select(a => a.ErrorMessage));
            }

            var feature = _mapper.Map<Domain.Feature>(request.Request);

            feature = await _unitOfWork.FeaturesRepository.AddAsync(feature);

            await _unitOfWork.Save(cancellationToken);

            return new Response(feature.Id);
        }
    }
}
