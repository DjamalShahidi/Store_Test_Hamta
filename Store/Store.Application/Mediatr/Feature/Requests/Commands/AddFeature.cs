using MediatR;
using Store.Application.DTOs.Feature;

namespace Store.Application.Mediatr.Feature.Requests.Commands
{
    public class AddFeature : IRequest<int>
    {
        public AddFeatureDto AddFeatureDto { get; set; }
    }
}
