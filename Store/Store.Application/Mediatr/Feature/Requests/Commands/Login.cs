﻿using MediatR;
using Store.Application.DTOs.Account;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Requests.Commands
{
    public class Login :IRequest<Response>
    {
        public LoginRequestDto Request { get; set; }
    }
}
