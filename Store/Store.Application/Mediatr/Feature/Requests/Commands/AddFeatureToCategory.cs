using MediatR;
using Store.Application.DTOs.Category;
using Store.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Mediatr.Feature.Requests.Commands
{
    public class AddFeatureToCategory : IRequest<Response>
    {
        public AddFeatureToCategoryDto Request { get; set; }

    }
}
