using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Mediatr.Feature.Requests.Queries;
using Store.Application.Responses;

namespace Store.Api.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class ProductController : ControllerBase
    //{
    //    private readonly IMediator _mediator;

    //    public ProductController(IMediator mediator)
    //    {
    //        this._mediator = mediator;
    //    }

    //    [HttpPost, Route("/Product")]
    //    public async Task<Response> AddProduct([FromBody] AddProduct addProduct)
    //    {
    //        return await _mediator.Send(addProduct);
    //    }

    //    [HttpGet, Route("/Products")]
    //    public async Task<Response> GetCategories([FromQuery] GetProducts getProducts)
    //    {
    //        return await _mediator.Send(getProducts);
    //    }
    //}
}
