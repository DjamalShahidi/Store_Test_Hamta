using AutoMapper;
using MediatR;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Category;
using Store.Application.DTOs.Product;
using Store.Application.Mediatr.Feature.Requests.Queries;
using Store.Application.Responses;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Mediatr.Feature.Handlers.Queries
{
    public class GetProductsHandler : IRequestHandler<GetProducts, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProductsHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Response> Handle(GetProducts request, CancellationToken cancellationToken)
        {
            var products=new List<Product>();

            if (request.CategoryId!=null)
            {
                var category = await _unitOfWork.CategoryRepository.GetAsync(request.CategoryId.Value);

                if (category == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        ErrorMessages = new List<string>() { "Category not found" }
                    };

                }

                products = await _unitOfWork.ProductRepository.GetProductByCategoryIdAsync(request.CategoryId.Value);

            }
            else
            {
                products = await _unitOfWork.ProductRepository.GetListAsyncWithInclude();
            }

            var productIds = products.Select(a => a.Id).ToList();

            var productFeatures = await _unitOfWork.ProductFeatureRepository.GetListByProductIds(productIds);

            var productDtos = _mapper.Map<List<GetProductDto>>(products);

            foreach (var item in productDtos)
            {
                item.CategoryTitle= products.Where(a=>a.Id==item.Id).Select(a=>a.Category.Title).FirstOrDefault();

                var features = productFeatures.Where(a => a.ProductId == item.Id).ToList();

                foreach (var featuer in features)
                {
                    item.Features.Add(new GetProductDtoFeature()
                    {
                        Name = featuer.Feature.Name,
                        Value = featuer.Feature.Value,
                    });
                }

            }

            return new Response(productDtos);
        }
    }
}
