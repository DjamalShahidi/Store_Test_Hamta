using MediatR;
using Store.Application.DTOs.Account;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Requests.Commands
{
    public class Register : IRequest<Response>
    {
        public RegisterationRequestDto Request { get; set; }
    }
}
