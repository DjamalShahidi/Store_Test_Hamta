using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Mediatr.Feature.Requests.Queries;
using Store.Application.Responses;

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeatureController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost, Route("/Feature")]
        public async Task<Response> AddFeature([FromBody] AddFeature addFeature)
        {
           return await _mediator.Send(addFeature);
        }

        [HttpGet,Route("/Features")]
        public async Task<Response> Get()
        {
           return await _mediator.Send(new GetFeatures());
        }
    }
}
