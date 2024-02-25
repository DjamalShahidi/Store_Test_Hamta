﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Mediatr.Feature.Requests.Queries;
using Store.Application.Responses;

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost, Route("/Category")]
        public async Task<Response> AddCategory([FromBody] AddCategory addCategory)
        {
            return await _mediator.Send(addCategory);
        }

        [HttpGet, Route("/Categories")]
        public async Task<Response> GetCategories()
        {
            return await _mediator.Send(new GetCategories());
        }

        [HttpPut, Route("/Category/features")]
        public async Task<Response> GetCategories(AddFeatureToCategory addFeatureToCategory)
        {
            return await _mediator.Send(addFeatureToCategory);
        }
    }
}