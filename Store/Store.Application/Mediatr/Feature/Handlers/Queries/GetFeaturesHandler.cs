using AutoMapper;
using MediatR;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Feature;
using Store.Application.Mediatr.Feature.Requests.Queries;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Handlers.Queries
{
    public class GetFeaturesHandler : IRequestHandler<GetFeatures, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetFeaturesHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Response> Handle(GetFeatures request, CancellationToken cancellationToken)
        {

            var features = await _unitOfWork.FeaturesRepository.GetListAsync();

            var featureDtos = _mapper.Map<List<GetFeatureDto>>(features);

            return new Response(featureDtos);
        }
    }
}
