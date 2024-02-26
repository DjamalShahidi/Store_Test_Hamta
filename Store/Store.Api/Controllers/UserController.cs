using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Account;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Mediatr.Feature.Requests.Queries;
using Store.Application.Responses;
using System.Net;

namespace Store.Api.Controllers
{
    [Route("api/v{version:apiVersion}/User")]
    [ApiController]
    [ApiVersionNeutral]
    public class UsersController : Controller
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<Response> Login([FromBody] Login login)
        {
            return await _mediator.Send(login);
        }

        [HttpPost("register")]
        public async Task<Response> Register([FromBody] Register register)
        {
            return await _mediator.Send(register);
        }

        //[HttpPost("register")]
        //public async Task<IActionResult> Register([FromBody] RegisterationRequestDTO model)
        //{
        //    bool ifUserNameUnique = _userRepo.IsUniqueUser(model.UserName);
        //    if (!ifUserNameUnique)
        //    {
        //        _response.StatusCode = HttpStatusCode.BadRequest;
        //        _response.IsSuccess = false;
        //        _response.ErrorMessages.Add("Username already exists");
        //        return BadRequest(_response);
        //    }

        //    var user = await _userRepo.Register(model);
        //    if (user == null)
        //    {
        //        _response.StatusCode = HttpStatusCode.BadRequest;
        //        _response.IsSuccess = false;
        //        _response.ErrorMessages.Add("Error while registering");
        //        return BadRequest(_response);
        //    }
        //    _response.StatusCode = HttpStatusCode.OK;
        //    _response.IsSuccess = true;
        //    return Ok(_response);
        //}
    }
}
