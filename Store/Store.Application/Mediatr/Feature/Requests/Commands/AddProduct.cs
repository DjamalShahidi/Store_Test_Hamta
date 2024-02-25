using MediatR;
using Store.Application.DTOs.Product;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Requests.Commands
{
    public class AddProduct : IRequest<Response>
    {
        public AddProductDto Request { get; set; }
    }
}
