using MediatR;
using Store.Application.DTOs.Product;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Requests.Queries
{
    public class GetProducts : IRequest<Response>
    {
        public int? CategoryId { get; set; }
    }
}
