using MediatR;
using Store.Application.DTOs.Feature;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Requests.Commands
{
    public class AddFeature : IRequest<Response>
    {
        public AddFeatureDto Request { get; set; }
    }
}
