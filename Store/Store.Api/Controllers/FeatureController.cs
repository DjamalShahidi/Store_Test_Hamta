using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Mediatr.Feature.Requests.Commands;

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

        [HttpPost]
        public async Task AddBook([FromBody] AddFeature addFeature)
        {
            await _mediator.Send(addFeature);
        }
    }
}
