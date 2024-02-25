using MediatR;
using Store.Application.DTOs.Category;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Requests.Commands
{
    public class AddCategory : IRequest<Response>
    {
        public AddCategoryDto Request { get; set; }
    }
}
