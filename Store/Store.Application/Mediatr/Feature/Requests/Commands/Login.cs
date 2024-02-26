using MediatR;
using Store.Application.DTOs.Account.Validators;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Requests.Commands
{
    public class Login :IRequest<Response>
    {
        public LoginDtoValidator Request { get; set; }
    }
}
