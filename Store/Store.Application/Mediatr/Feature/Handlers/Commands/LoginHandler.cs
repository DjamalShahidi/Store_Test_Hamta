using AutoMapper;
using MediatR;
using Microsoft.AspNet.Identity;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Account.Validators;
using Store.Application.DTOs.Product.Validator;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Responses;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Mediatr.Feature.Handlers.Commands
{
    //public class LoginHandler : IRequestHandler<Login, Response>
    //{
    //    private readonly UserManager<User> _userManager;
    //    private readonly IMapper _mapper;

    //    public LoginHandler(JWTService jWTService, UserManager<User> userManager, IMapper mapper)
    //    {
    //        this._userManager = userManager;
    //        this._mapper = mapper;
    //    }

    //    public async Task<Response> Handle(Login request, CancellationToken cancellationToken)
    //    {
    //        var validator = new LoginDtoValidator(_unitOfWork);
    //        var validatorResult = await validator.ValidateAsync(request.Request);
    //    }

    //}
}
