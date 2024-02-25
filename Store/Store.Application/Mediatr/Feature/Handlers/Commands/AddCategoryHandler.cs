using AutoMapper;
using MediatR;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Category;
using Store.Application.DTOs.Category.Validators;
using Store.Application.DTOs.Feature.Validators;
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
    public class AddCategoryHandler : IRequestHandler<AddCategory, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddCategoryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Response> Handle(AddCategory request, CancellationToken cancellationToken)
        {
            var validator = new AddCategoryDtoValidator(_unitOfWork);
            var validatorResult = await validator.ValidateAsync(request.AddCategoryDto);

            if (validatorResult.IsValid == false)
            {
                return new Response(validatorResult.Errors.Select(a => a.ErrorMessage));
            }

            var category = _mapper.Map<Category>(request.AddCategoryDto);

            category = await _unitOfWork.CategoryRepository.AddAsync(category);

            await _unitOfWork.Save(cancellationToken);

            return new Response(category.Id);
        }

    }
}
