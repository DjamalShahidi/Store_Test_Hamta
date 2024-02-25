using AutoMapper;
using MediatR;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Category;
using Store.Application.DTOs.Feature;
using Store.Application.Mediatr.Feature.Requests.Queries;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Handlers.Queries
{
    public class GetCategoriesHandler : IRequestHandler<GetCategories, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCategoriesHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Response> Handle(GetCategories request, CancellationToken cancellationToken)
        {
            var categories = await _unitOfWork.CategoryRepository.GetListAsync();

            var categoryIds= categories.Select(a=>a.Id).ToList();

            var categoryFeatures = await _unitOfWork.CategoryFeatureRepository.GetListByCategoryIds(categoryIds);

            var categoryDtos = _mapper.Map<List<GetCategoryDto>>(categories);

            foreach (var item in categoryDtos)
            {
                var categoryFeaturesForThisCategory = categoryFeatures.Where(a=>a.CategoryId==item.Id).ToList();

                foreach (var featuer in categoryFeaturesForThisCategory)
                {
                    item.Features.Add(new GetCategoryFeatureDto()
                    {
                        Id = featuer.Feature.Id,
                        Name = featuer.Feature.Name,
                        Value = featuer.Feature.Value,
                    });
                }

            }

            return new Response(categoryDtos);
        }
    }
}
